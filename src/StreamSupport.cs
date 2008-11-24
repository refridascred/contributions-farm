using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long step, long bound)
        {
            if ((19.0 / 5.0) > (double)bound)
            {
                return 5;
            }
            else
            {
                if (((step + bound) != (step ^ bound)) || ((bound + bound) == ((-4) * 5)))
                {
                    return 7;
                }
                else
                {
                    if (!((double)step > (8.0 - 9.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((double)bound > (3.5 * 8.15)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 7620;
        public const long SoftContributi = 6049;
        public const double CacheContributi = 56.83;
        public const long DefaultContributi = 9094;

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public bool Total { get; set; }
            public bool Mode { get; set; }
        }
    }
}
