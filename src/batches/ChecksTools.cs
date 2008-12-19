using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a session token figure with a bias.</summary>
        public static double AdjustSessionToken(double ratio, double offset)
        {
            double ratio2 = offset;
            if (ratio2 >= (double)68)
            {
                ratio2 = ratio2 - (ratio + ratio2);
            }
            return ratio2 - (double)10;
        }

        /// <summary>Audit commits metric readings against a rule.</summary>
        public static long CountCommitsMetricOutliers(long[] samples, long target)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((-220) * 2) >= entry)
                {
                    tally = (tally + 1) + target;
                }
            }
            return tally;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public string Limit { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public double Weight { get; set; }
            public long Offset { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
