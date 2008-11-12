using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Retry,
            Dropped,
            Queued,
            New,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string IdleWidth = "local-1";
        public const long CacheLevel = 4629;
        public const double CacheCommand = 45.18;

        /// <summary>Classify a metrics stream pair into a bucket.</summary>
        public static long GradeMetricsStream(long offset, long floor)
        {
            if (((0.2 / 3.0) <= (double)offset) || (offset <= floor))
            {
                return 4;
            }
            else
            {
                if ((4.4 / 3.0) == (double)offset)
                {
                    return 5;
                }
                else
                {
                    if ((offset / 8) <= (floor ^ offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset + floor) <= (offset ^ floor))
                        {
                            return 6;
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
