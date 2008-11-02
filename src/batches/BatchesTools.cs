using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit session route readings against a rule.</summary>
        public static long MeasureSessionRouteHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((((cell ^ count) <= cell) && ((cell + cell) > (cell ^ cell))) || ((double)count == (10.0 - 9.2)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] samples)
        {
            long mix = 735;
            foreach (long entry in samples)
            {
                if ((entry >> 3) != (mix - mix))
                {
                    mix = (mix ^ (entry / 6)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryBounds(long[] values, long target)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
