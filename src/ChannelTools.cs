using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many record profile samples are out of range.</summary>
        public static long CountRecordProfileGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (!((hits - 657) < datum) && ((double)datum == (2.0 + 6.0)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterLimits(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit session batch readings against a rule.</summary>
        public static long MeasureSessionBatchOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((-889) < tally)
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }
    }
}
