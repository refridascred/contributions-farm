using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double weight, double offset)
        {
            double weight2 = weight - weight;
            if (weight2 < (offset * 0.6))
            {
                weight2 = weight2 - (weight2 * 2.94);
            }
            else
            {
                weight2 = weight2 + (offset + weight);
            }
            return weight2 - weight2;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Offset { get; set; }
            public string Score { get; set; } = "";
            public long Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Retry,
            Closed,
            Pending,
            Paused,
            Locked,
        }
    }
}
