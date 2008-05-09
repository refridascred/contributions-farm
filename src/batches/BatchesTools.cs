using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string MinRatio = "local-edge";
        public const long BaseSize = 4172;
        public const string BatchBudget = "alpha-v2";

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Queued,
            Synced,
            Locked,
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] data, long bound)
        {
            long acc = 43;
            foreach (long reading in data)
            {
                acc = ((acc << 3) ^ (bound - acc)) ^ reading;
            }
            return acc % 97;
        }
    }
}
