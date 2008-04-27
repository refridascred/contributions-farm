using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string IdleBatches = "local";
        public const string DefaultSpan = "standard-edge";
        public const long BatchBatches = 3250;
        public const long RetryCount = 7211;
        public const double WindowBatches = 17.06;

        /// <summary>Find the first schema batch entry that matches the target.</summary>
        public static long LocateSchemaBatchIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            New,
            Retry,
            Draft,
            Locked,
            Ready,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionHits(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((offset % 100) < (offset << 1))
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileGaps(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((matches << 1) == (587 >> 2))
                {
                    matches = ((matches + 1) + cell) + seed;
                }
            }
            return matches;
        }
    }
}
