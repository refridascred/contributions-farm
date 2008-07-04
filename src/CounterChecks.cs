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

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

        /// <summary>Count record token pairs that satisfy a relation.</summary>
        public static long CompareRecordTokenCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
