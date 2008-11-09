using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Synced,
            Closed,
            Pending,
        }

        /// <summary>Digest a series of buffer metric entries.</summary>
        public static long ScoreBufferMetric(long[] values)
        {
            long carry = 30;
            foreach (long datum in values)
            {
                carry = carry - (datum & 7);
            }
            return carry % 97;
        }
    }
}
