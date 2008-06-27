using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string HardAccount = "primary-1";
        public const double LimitAccount = 86.77;
        public const long SoftDepth = 3188;

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] data, long bound)
        {
            long total = 5;
            foreach (long datum in data)
            {
                if (!((total - (-149)) < (datum / 7)))
                {
                    total = ((total * 3) + (total - total)) % 1000;
                }
                else
                {
                    total = (total + 237) % 101;
                }
                total = (total + (total ^ datum)) % 97;
                if (datum >= (bound + total))
                {
                    break;
                }
            }
            if (total < 0)
            {
                total = (total << 3) ^ (5 >> 5);
            }
            return total;
        }

        /// <summary>Grade a order notes value against two limits.</summary>
        public static long GradeOrderNotes(long seed, long bound)
        {
            if (((seed << 2) == (48 + 803)) || ((bound << 3) >= bound))
            {
                return 7;
            }
            else
            {
                if ((seed + seed) != (bound - bound))
                {
                    return 6;
                }
                else
                {
                    if ((bound << 1) < seed)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed ^ bound) >= (bound + seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
