using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Owner { get; set; }
            public bool Rank { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Compare every pair of layout channel readings.</summary>
        public static long CompareLayoutChannelCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Mode { get; set; }
            public double Region { get; set; }
            public long Level { get; set; }
        }
    }
}
