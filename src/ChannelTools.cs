using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Closed,
            Queued,
            New,
            Pending,
            Failed,
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

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmHits(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((tally ^ tally) != (cell - tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
