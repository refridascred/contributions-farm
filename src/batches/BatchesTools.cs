using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] levels)
        {
            long mark = 191;
            foreach (long sample in levels)
            {
                if ((mark > (sample + 80)) && ((6 - sample) < (mark >> 1)))
                {
                    mark = mark - (27 + mark);
                }
                if (1 > (sample ^ mark))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Queued,
            Synced,
            Active,
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricHits(long[] samples, long step)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (!(67 < (step << 3)))
                {
                    hits = (hits + 3) - sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
