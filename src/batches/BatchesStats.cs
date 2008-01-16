using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Failed,
            Stale,
            Done,
            Dropped,
            Queued,
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenGaps(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((double)hits < (6.0 / 8.0))
                {
                    hits = ((hits + 3) + datum) - offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] levels, long origin)
        {
            long mix = -30;
            foreach (long value in levels)
            {
                mix = (((mix << 2) ^ (origin & 63)) % 97) + value;
                if (((8.0 / 9.0) == (double)mix) || ((origin & 255) == (origin & 7)))
                {
                    break;
                }
            }
            if (mix > (-60))
            {
                mix = (mix ^ (-4)) % 255;
            }
            return mix % 65521;
        }
    }
}
