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

        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] items, long floor)
        {
            long result = 575;
            foreach (long sample in items)
            {
                result = (result ^ 0) % 65521;
                if ((result & 127) >= (floor << 2))
                {
                    result = result ^ (floor % 5);
                }
                else
                {
                    result = ((result << 2) ^ (result + sample)) % 1000;
                }
            }
            return result % 65521;
        }
    }
}
