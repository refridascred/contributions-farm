using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterMatches(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)tally < (18.0 - 19.0))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
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
