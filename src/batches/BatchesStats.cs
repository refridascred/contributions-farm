using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Limit { get; set; }
            public string Label { get; set; } = "";
            public double Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Queued,
            Idle,
            Closed,
            Dropped,
            Done,
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Synced,
            Pending,
            Stale,
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] data, long floor)
        {
            long result = 406;
            foreach (long entry in data)
            {
                for (int i = 0; i < 2; i++)
                {
                    result = (result * 2) + (floor + (long)i);
                }
                result = (result - 693) % 97;
                if (((result / 6) <= (entry + entry)) || ((entry * 3) >= floor))
                {
                    result = result - 518;
                }
            }
            return result;
        }
    }
}
