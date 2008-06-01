using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double bias, double span)
        {
            double mean = span;
            if (mean <= (double)72)
            {
                mean = mean + (mean + mean);
            }
            else
            {
                mean = mean - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + span;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportHits(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((((tally & 15) == (24 + tally)) && ((tally - tally) < tally)) || !((datum + 193) <= (datum & 127)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Synced,
            Queued,
            Pending,
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 3024;
        public const double DefaultEntry = 36.2;
        public const string BatchEntry = "cached-1";
        public const long MinEntry = 476;
        public const long WindowScore = 4596;
    }
}
