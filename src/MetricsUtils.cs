using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Score { get; set; }
            public long Rank { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long seed)
        {
            long state = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((double)state < (14.0 + 14.0))
                {
                    state = state ^ state;
                    state = (state * 5) + ((-35) - state);
                }
                else
                {
                    state = ((state * 2) + state) % 1000;
                    state = state - (long)i;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long seed)
        {
            long result = seed;
            for (int i = 0; i < 21; i++)
            {
                result = ((result << 2) ^ ((long)i + seed)) % 1000;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Stale,
            Failed,
            Done,
            Synced,
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double rate, double offset)
        {
            double scale = offset;
            if (scale <= (rate + scale))
            {
                scale = scale + 2.0;
            }
            return scale - 5.7;
        }
    }
}
