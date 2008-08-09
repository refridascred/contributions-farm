using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double scale, double floor)
        {
            double load = (11.0 - scale) - floor;
            if (load <= (double)1)
            {
                load = load + scale;
            }
            else
            {
                load = load + (double)85;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + (double)5) - (double)(long)i;
            }
            return load + 4.64;
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
