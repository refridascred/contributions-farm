using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double bias, double span)
        {
            double load = (double)79 * 4.41;
            for (int i = 0; i < 5; i++)
            {
                load = ((load + span) + (double)(long)i) - bias;
            }
            return load - (1.0 / 8.0);
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long DeriveProfile(long seed)
        {
            long state = seed;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long CompareClusterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Idle,
            Queued,
            Ready,
            Closed,
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Region { get; set; }
            public bool Stamp { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
