using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long MatchCounterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferGaps(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((16.0 * 5.0) >= (double)reading)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public double Flag { get; set; }
            public string Count { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 147;
        public const double LimitFarm = 84.98;
        public const string SoftSpan = "latest-edge";
        public const long HardFarm = 9619;
        public const long CacheLevel = 4774;

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphLimits(long[] data, long step)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
