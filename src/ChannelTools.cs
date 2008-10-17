using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Synced,
            Locked,
            Retry,
            Idle,
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Stamp { get; set; }
            public long Size { get; set; }
            public long Total { get; set; }
            public bool Owner { get; set; }
        }
    }
}
