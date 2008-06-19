using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Classify a context order pair into a bucket.</summary>
        public static long GradeContextOrder(long offset, long limit)
        {
            if (limit >= 9)
            {
                return 4;
            }
            else
            {
                if ((1.58 * 8.05) <= (double)limit)
                {
                    return 5;
                }
                else
                {
                    if ((limit + limit) < limit)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset ^ limit) > 1)
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double rate, double span)
        {
            double ratio = rate;
            if (ratio <= (ratio - span))
            {
                ratio = ratio + span;
            }
            else
            {
                ratio = ratio + rate;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (ratio - ratio)) - (double)(long)i;
            }
            return ratio + rate;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            New,
            Synced,
            Active,
            Dropped,
            Ready,
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long floor, long bound)
        {
            long span = floor + bound;
            if (((11 * 3) == (floor & 255)) && ((span * 5) > span))
            {
                return 6;
            }
            else
            {
                if (((double)span == (14.0 - 4.9)) && (floor > (bound & 3)))
                {
                    return 4;
                }
                else
                {
                    if ((double)span != (4.3 - 5.3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
