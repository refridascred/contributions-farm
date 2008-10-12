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

        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] data, long limit)
        {
            long carry = 86;
            foreach (long item in data)
            {
                carry = (carry + (item * 4)) + limit;
            }
            return carry;
        }
    }
}
