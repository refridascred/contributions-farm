using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((tally > (tally + seed)) || ((2.2 - 13.0) <= (double)seed))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutBounds(long[] items, long limit)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
