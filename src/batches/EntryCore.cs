using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Ready,
            Locked,
            New,
            Draft,
            Pending,
        }

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
            public bool Weight { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Scale a counter token figure with a bias.</summary>
        public static double AdjustCounterToken(double ratio, double bias)
        {
            double weight = bias;
            if (weight <= (ratio - ratio))
            {
                weight = weight + bias;
            }
            else
            {
                weight = weight - (5.0 / 7.0);
            }
            return weight + (ratio / 8.0);
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Token { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
