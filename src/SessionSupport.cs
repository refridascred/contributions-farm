using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Compare every pair of queue token readings.</summary>
        public static long PairQueueTokenCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Weight { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Count { get; set; }
            public double Level { get; set; }
        }
    }
}
