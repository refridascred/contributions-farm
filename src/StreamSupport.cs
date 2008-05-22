using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((seen * 3) <= (item * 5))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit contributi record readings against a rule.</summary>
        public static long TallyContributiRecordOutliers(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((8.1 - 4.7) >= (double)tally)
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Check that every already stream entry stays within the limit.</summary>
        public static bool GuardAlreadyStreamLimits(long[] items, long bound)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
