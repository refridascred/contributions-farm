using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long MinSupport = 3909;
        public const double CacheSupport = 90.51;
        public const double SoftRatio = 6.07;
        public const long MinSize = 6206;
        public const double LimitSpan = 84.5;

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((double)tally <= (0.9 / 2.0)) || (((double)(long)data.Length == (double)7) && (tally <= (91 >> 2))))
                {
                    tally = ((tally + 2) + reading) + seed;
                }
            }
            return tally;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double AdjustContext(double weight, double bias)
        {
            double ratio = bias;
            return (ratio + (1.6 + ratio)) + weight;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (((73 >> 2) != (floor + 23)) && ((floor - floor) == (count + floor)))
                {
                    count = (count + 1) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long seed, long bound)
        {
            long cur = seed + bound;
            if (cur < (cur >> 3))
            {
                return 0;
            }
            else
            {
                if ((7.17 * 4.7) != (double)seed)
                {
                    return 8;
                }
                else
                {
                    if (((seed - cur) <= seed) && (573 < (cur + seed)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound + cur) != (bound % 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
            public double Owner { get; set; }
        }
    }
}
