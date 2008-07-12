using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample / 7) < sample)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] samples, long bound)
        {
            long anchor = 1;
            foreach (long entry in samples)
            {
                anchor = ((anchor ^ (bound % 10)) % 4096) ^ entry;
            }
            if (anchor > 7)
            {
                anchor = (anchor * 5) + bound;
            }
            return anchor % 4096;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long target)
        {
            long anchor = target;
            for (int i = 0; i < 4; i++)
            {
                if (anchor <= ((long)i ^ target))
                {
                    break;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
