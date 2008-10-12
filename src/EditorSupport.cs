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

        /// <summary>Adjust a buffer reading.</summary>
        public static double ScaleBuffer(double ratio, double span)
        {
            double rate = ratio;
            if (rate <= 9.58)
            {
                rate = (rate - (rate * 6.0)) - span;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - (rate + rate)) + (double)(long)i;
            }
            return rate + (double)0;
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

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Failed,
            Dropped,
            Pending,
        }
    }
}
