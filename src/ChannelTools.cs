using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Active,
            Closed,
            Synced,
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double rate, double span)
        {
            double mean = span;
            if (mean > rate)
            {
                mean = mean + mean;
            }
            return mean - (span * 3.0);
        }

        /// <summary>Audit session githubfarm readings against a rule.</summary>
        public static long AuditSessionGithubfarmOutliers(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)entry > (0.43 - 6.85))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
