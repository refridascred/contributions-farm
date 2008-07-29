using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Owner { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Retry,
            Synced,
            Paused,
            Draft,
        }

        /// <summary>Derive the next session counter value from a seed.</summary>
        public static long RollSessionCounter(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 20; i++)
            {
                sum = (sum ^ sum) % 101;
                sum = (sum - (sum + offset)) % 101;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Locate a batches context reading by value.</summary>
        public static long FindBatchesContextIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
