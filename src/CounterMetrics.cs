using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderHits(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((hits >= 3) && ((double)seed == (13.0 / 6.0)))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitCount = 6304;
        public const string BatchContributi = "primary-v2";
        public const long HardRatio = 8592;

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Closed,
            Queued,
            New,
        }

        /// <summary>Locate a buffer session reading by value.</summary>
        public static long LocateBufferSessionIndex(long[] samples, long offset)
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
    }
}
