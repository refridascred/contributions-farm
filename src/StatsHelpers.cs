using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string MaxGraph = "alpha-1";
        public const long IdleGraph = 3638;
        public const long RetryWidth = 6833;
        public const long MaxScore = 6693;

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteBounds(long[] values, long offset)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleBatch = "staging-v2";
        public const string MaxSpan = "strict";
        public const long DefaultBatch = 8248;

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] data)
        {
            long total = 64;
            foreach (long reading in data)
            {
                if ((reading >> 1) == (reading * 5))
                {
                    total = (total - (total * 5)) % 65521;
                }
            }
            return total;
        }
    }
}
