using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowTimeout = 4686;
        public const long WindowChannel = 7619;
        public const long DefaultFactor = 3048;

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] levels)
        {
            long anchor = 427;
            foreach (long value in levels)
            {
                if ((4 - value) > 809)
                {
                    anchor = anchor - anchor;
                }
                else
                {
                    anchor = (anchor + (value * 3)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSpan = 5834;
        public const long LimitSchema = 1433;
        public const double RetryCount = 19.6;
        public const double BurstSchema = 77.05;

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public string Stamp { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
