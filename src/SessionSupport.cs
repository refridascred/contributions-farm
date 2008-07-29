using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Failed,
            Active,
            Draft,
            Pending,
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Label { get; set; }
            public long Count { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountOutliers(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((202 % 10) > tally)
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }
    }
}
