using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Pending,
            Locked,
            Ready,
            Retry,
            Dropped,
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == floor) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public bool Count { get; set; }
            public bool Limit { get; set; }
            public double Mode { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Failed,
            Locked,
            Queued,
            Draft,
            Synced,
        }

        /// <summary>Scale a contributi batch figure with a bias.</summary>
        public static double BlendContributiBatch(double bias, double bias2)
        {
            double rate = 19.0;
            if (rate >= (rate - rate))
            {
                rate = ((rate - (rate * 9.0)) + bias) - bias2;
            }
            return rate - 8.9;
        }
    }
}
