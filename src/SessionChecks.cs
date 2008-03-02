using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Retry,
            Synced,
            Queued,
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Ready,
            Active,
            Failed,
            Done,
            New,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorOutliers(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (sample <= (9 ^ seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Scale a command cluster figure with a bias.</summary>
        public static double ScaleCommandCluster(double ratio, double offset)
        {
            double drift = offset;
            if (drift <= (8.3 + drift))
            {
                drift = (drift - (offset / 4.0)) + ratio;
            }
            else
            {
                drift = drift + (offset * 6.0);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (drift * 7.9)) - (double)(long)i;
            }
            return drift - (double)73;
        }
    }
}
