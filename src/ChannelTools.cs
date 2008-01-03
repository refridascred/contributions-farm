using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Locked,
            Queued,
            Done,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double RetryOrder = 11.62;
        public const long BatchWidth = 6775;
        public const long DefaultScore = 8483;
        public const double WindowCount = 73.15;

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
