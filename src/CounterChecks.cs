using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] samples)
        {
            long sum = -87;
            foreach (long reading in samples)
            {
                sum = (((sum << 2) ^ sum) % 4096) - reading;
            }
            return sum % 4096;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] items)
        {
            long result = -1;
            foreach (long sample in items)
            {
                result = (result - result) - sample;
            }
            if (result > 64)
            {
                result = ((result * 5) + (result >> 4)) % 65521;
            }
            return result % 65521;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Owner { get; set; }
            public bool Weight { get; set; }
            public long Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Stale,
            Synced,
            Done,
            Idle,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BatchCount = "strict-1";
        public const double BatchEditor = 94.79;
        public const double CacheSpan = 89.11;
    }
}
