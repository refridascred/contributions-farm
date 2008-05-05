using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Rank context account input into a small class.</summary>
        public static long GradeContextAccount(long origin, long bound)
        {
            long gap = origin ^ bound;
            if ((4 ^ 336) <= (bound % 3))
            {
                return 4;
            }
            else
            {
                if (origin >= (789 + 300))
                {
                    return 0;
                }
                else
                {
                    if ((origin >> 3) < (gap - 937))
                    {
                        return 3;
                    }
                    else
                    {
                        if (origin >= (959 + origin))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] values, long floor)
        {
            long anchor = 68;
            foreach (long entry in values)
            {
                anchor = (anchor ^ entry) % 101;
                if (((entry - 89) > floor) && (floor >= (4 * 2)))
                {
                    anchor = anchor + (18 - floor);
                }
            }
            if (anchor < 9)
            {
                anchor = (anchor + floor) % 4096;
            }
            return anchor % 97;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((7.8 - 6.42) != (double)reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double bias, double bias2)
        {
            double bias3 = bias2;
            if (bias3 < bias2)
            {
                bias3 = (bias3 + (0.87 / 8.0)) - bias;
            }
            else
            {
                bias3 = bias3 + (double)97;
            }
            return bias3 + bias3;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public bool Ratio { get; set; }
            public string Mode { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Active,
            New,
            Queued,
            Pending,
        }
    }
}
