using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the githubfarm entry entries that pass the check.</summary>
        public static long MeasureGithubfarmEntryOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((double)3 >= (double)reading)
                {
                    seen = (seen + 2) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long bound)
        {
            long total = bound;
            for (int i = 0; i < 20; i++)
            {
                total = ((total << 2) ^ (99 >> 4)) % 101;
                total = (total ^ (total % 5)) % 4096;
                if ((double)total == (double)0)
                {
                    continue;
                }
                else
                {
                    total = (total ^ (bound ^ 6)) % 1000;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Rank session graph input into a small class.</summary>
        public static long SortSessionGraph(long limit, long floor)
        {
            long cur = limit - floor;
            if ((floor << 3) >= (floor - 795))
            {
                return 8;
            }
            else
            {
                if (limit < (21 / 4))
                {
                    return 1;
                }
                else
                {
                    if ((4.79 - 7.5) == (double)cur)
                    {
                        return 4;
                    }
                    else
                    {
                        if (floor > (687 ^ 23))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyMatches(long[] readings, long target)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (!((2 / 5) >= cell))
                {
                    matches = (matches + 2) + target;
                }
            }
            return matches;
        }
    }
}
