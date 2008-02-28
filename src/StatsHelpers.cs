using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] series)
        {
            long carry = 3;
            foreach (long item in series)
            {
                carry = (carry * 3) + (419 * 3);
                carry = carry ^ (item / 9);
                if ((carry + carry) >= (item << 1))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchLimits(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Flag { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
