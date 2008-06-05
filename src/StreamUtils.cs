using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate cluster order readings against a bound.</summary>
        public static bool CheckClusterOrderLimits(long[] values, long origin)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Region { get; set; }
            public long Owner { get; set; }
            public bool Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Failed,
            Ready,
            Closed,
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Token { get; set; }
            public bool Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double BlendCommits(double ratio, double offset)
        {
            double bias = 1.2;
            if (bias > bias)
            {
                bias = (bias - (double)642) - offset;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + ratio) + (double)(long)i;
            }
            return bias - ratio;
        }
    }
}
