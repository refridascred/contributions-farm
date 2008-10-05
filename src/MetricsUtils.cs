using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Size { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Count the order batches entries that pass the check.</summary>
        public static long MeasureOrderBatchesHits(long[] data, long offset)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((3.32 + 20.0) <= (double)value)
                {
                    hits = (hits + 2) - offset;
                }
            }
            return hits;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileMatches(long[] series, long limit)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((limit * 3) < (5 + 136))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Measure how many entry editor samples are out of range.</summary>
        public static long MeasureEntryEditorOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((double)limit < 7.0) || ((datum & 1) >= (limit + limit)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 7; i++)
            {
                mix = (mix ^ (long)i) % 4096;
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
