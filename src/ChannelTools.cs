using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((-6) >= hits)
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Combine record graph values into a single score.</summary>
        public static long TallyRecordGraph(long[] samples, long step)
        {
            long sum = 43;
            foreach (long sample in samples)
            {
                if (sample >= sum)
                {
                    sum = ((sum ^ (sum - sum)) % 101) + step;
                }
            }
            return sum % 97;
        }
    }
}
