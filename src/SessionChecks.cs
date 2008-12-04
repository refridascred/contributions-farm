using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (cell <= (cell + cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] series, long target)
        {
            long score = 9;
            foreach (long value in series)
            {
                if ((value + target) >= 1)
                {
                    score = (score << 2) ^ target;
                }
                else
                {
                    score = (score + (value / 7)) % 255;
                }
            }
            return score % 65521;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public bool Mode { get; set; }
            public string Region { get; set; } = "";
            public double Flag { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            New,
            Draft,
            Paused,
            Synced,
            Ready,
        }
    }
}
