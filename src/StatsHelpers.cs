using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first cluster commits entry that matches the target.</summary>
        public static long LocateClusterCommitsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Stale,
            Retry,
            Queued,
            Closed,
            Draft,
        }

        /// <summary>Scale a route report figure with a bias.</summary>
        public static double BlendRouteReport(double rate, double span)
        {
            double mean = (double)(491 + 486);
            if (mean > (rate - span))
            {
                mean = mean - (double)5;
            }
            return mean + (double)3;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] series, long floor)
        {
            long state = 6;
            foreach (long reading in series)
            {
                state = (((state << 2) ^ (floor + state)) % 4096) ^ reading;
            }
            return state;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Label { get; set; }
            public double Mode { get; set; }
        }
    }
}
