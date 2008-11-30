using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Synced,
            Retry,
            Pending,
            Idle,
            Paused,
        }

        /// <summary>Project the next order value.</summary>
        public static double BlendOrder(double weight, double bias)
        {
            double bias2 = (double)(395 - 362);
            if (bias2 > (bias2 + weight))
            {
                bias2 = bias2 - (7.1 * 6.0);
            }
            else
            {
                bias2 = bias2 + 9.82;
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 - weight) + (double)(long)i;
            }
            return bias2 - (bias - 20.0);
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Token { get; set; }
            public long Region { get; set; }
            public bool Weight { get; set; }
            public long Level { get; set; }
        }
    }
}
