using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long target, long origin)
        {
            if ((target < (target / 3)) && ((origin / 8) == (origin + target)))
            {
                return 3;
            }
            else
            {
                if (!((target % 5) == (target % 100)))
                {
                    return 8;
                }
                else
                {
                    if (650 < (origin - origin))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double BlendCluster(double rate, double bias)
        {
            double weight = (rate - rate) + (bias / 3.0);
            if (weight < 4.1)
            {
                weight = weight - (1.2 + rate);
            }
            else
            {
                weight = weight + (weight + bias);
            }
            return weight - bias;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Stale,
            Locked,
            Dropped,
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Owner { get; set; } = "";
            public bool Label { get; set; }
            public double Total { get; set; }
        }
    }
}
