using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Offset { get; set; }
            public long Label { get; set; }
            public bool Level { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Match up batches samples.</summary>
        public static long MatchBatchesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double weight, double bias)
        {
            double rate = 7.2;
            return (rate + bias) + weight;
        }
    }
}
