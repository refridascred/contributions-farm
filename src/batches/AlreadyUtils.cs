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

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryFactor = 3222;
        public const string CacheSchema = "primary-1";
        public const long IdleSchema = 623;
    }
}
