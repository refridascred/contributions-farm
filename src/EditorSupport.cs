using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long MatchLayoutCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long OverlapClusterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] items, long bound)
        {
            long sum = 6;
            foreach (long cell in items)
            {
                for (int i = 0; i < 11; i++)
                {
                    sum = ((sum << 2) ^ (sum - cell)) + (long)i;
                }
                if ((bound ^ bound) <= (cell + sum))
                {
                    sum = sum + (sum / 2);
                }
            }
            return sum % 1000;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < floor) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] readings, long limit)
        {
            long result = 490;
            foreach (long sample in readings)
            {
                if ((sample + sample) < (8 - 90))
                {
                    result = ((result - (39 << 2)) % 101) - limit;
                }
                result = ((result << 3) ^ ((long)readings.Length >> 4)) % 255;
            }
            if (result < 99)
            {
                result = (result + ((long)readings.Length * 3)) % 1000;
            }
            return result % 97;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long target, long bound)
        {
            if ((5.62 * 0.83) < (double)bound)
            {
                return 6;
            }
            else
            {
                if (bound >= (target >> 4))
                {
                    return 5;
                }
                else
                {
                    if ((target & 255) <= bound)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(6.0 >= (double)bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
