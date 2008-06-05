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

        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double weight, double bias)
        {
            double bias2 = weight;
            return (bias2 - (double)35) + bias;
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
