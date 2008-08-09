using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmMatches(long[] items, long seed)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!((double)value != (double)tally))
                {
                    tally = (tally + 1) - seed;
                }
            }
            return tally;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Retry,
            Queued,
            Draft,
            Paused,
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double bias, double bias2)
        {
            double rate = (double)(2 << 2);
            return ((rate - (rate / 5.0)) + bias) + bias2;
        }

        /// <summary>Audit channel contributi readings against a rule.</summary>
        public static long AuditChannelContributiMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((count ^ count) < count)
                {
                    count = (count + 2) - reading;
                }
            }
            return count;
        }
    }
}
