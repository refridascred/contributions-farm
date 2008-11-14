using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] readings)
        {
            long anchor = 4;
            foreach (long entry in readings)
            {
                if ((8 + anchor) <= (entry + 49))
                {
                    anchor = anchor - (anchor >> 3);
                }
                else
                {
                    anchor = (anchor + anchor) % 255;
                }
                if (!(entry < (anchor >> 3)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueLimits(long[] items, long offset)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextGaps(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((floor ^ tally) > tally)
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }
    }
}
