using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Idle,
            Closed,
            Active,
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountGaps(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count <= (count * 3)) && ((count << 2) < ((long)samples.Length - reading)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
