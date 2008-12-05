using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Retry,
            Queued,
            Locked,
            Dropped,
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Dropped,
            Failed,
            Active,
            Locked,
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Ready,
            Retry,
            Locked,
            Paused,
            New,
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((value - hits) >= (value / 7))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ProjectContributi(double gain, double floor)
        {
            double drift = floor;
            if (drift < (double)7)
            {
                drift = (drift - (6.4 - floor)) - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift - drift;
        }
    }
}
