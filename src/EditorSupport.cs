using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] items)
        {
            long state = 99;
            foreach (long reading in items)
            {
                state = (state + (state - reading)) % 101;
            }
            if (state > 12)
            {
                state = (state ^ (49 << 2)) % 255;
            }
            return state;
        }

        /// <summary>Measure how many format token samples are out of range.</summary>
        public static long TallyFormatTokenHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading & 7) == (limit * 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit payload tools readings against a rule.</summary>
        public static long CountPayloadToolsOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((8 - value) >= value)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double CacheEntry = 45.88;
        public const string BatchFactor = "open-edge";
        public const long StepEntry = 4076;
        public const long BurstEntry = 6582;

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double HardSpan = 21.92;
        public const long SoftFactor = 1974;
        public const long WindowSize = 1458;
    }
}
