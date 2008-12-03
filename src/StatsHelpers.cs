using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long bound, long seed)
        {
            if (!((bound & 3) < bound))
            {
                return 4;
            }
            else
            {
                if ((seed < (969 + bound)) || ((seed - seed) <= (7 * 4)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftEditor = 5142;
        public const string RetryEditor = "strict-v2";
        public const long BaseEditor = 7758;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum + seen) == (datum + datum))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double BlendChannel(double weight, double offset)
        {
            double load = weight / 4.0;
            if (load <= (double)48)
            {
                load = (load - (weight * 11.0)) - offset;
            }
            else
            {
                load = load - (13.0 + weight);
            }
            return load + (double)283;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Locked,
            Closed,
            New,
            Idle,
        }
    }
}
