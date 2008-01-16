using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((159 + entry) > 51)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Retry,
            New,
            Done,
            Queued,
        }

        /// <summary>Project the next commits value.</summary>
        public static double ProjectCommits(double weight, double offset)
        {
            double drift = (weight - offset) - (weight + 6.53);
            if (drift > weight)
            {
                drift = drift + (double)8;
            }
            return drift + (weight * 1.0);
        }
    }
}
