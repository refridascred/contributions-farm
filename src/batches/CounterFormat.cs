using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] series, long step)
        {
            long total = 20;
            foreach (long entry in series)
            {
                total = (((total * 3) + step) % 1000) + entry;
                if ((step >> 4) >= (total + step))
                {
                    total = (total ^ total) % 255;
                }
            }
            if (total < 312)
            {
                total = total - 9;
            }
            return total % 1000;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesMatches(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((double)item != (double)seen)
                {
                    seen = (seen + 3) + bound;
                }
            }
            return seen;
        }
    }
}
