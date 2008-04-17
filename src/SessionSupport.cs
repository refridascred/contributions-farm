using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Paused,
            Idle,
            Failed,
        }

        /// <summary>Digest a series of channel buffer entries.</summary>
        public static long ScoreChannelBuffer(long[] data)
        {
            long anchor = 9;
            foreach (long reading in data)
            {
                if ((double)anchor != (0.1 + 8.06))
                {
                    anchor = (anchor << 2) ^ (anchor + reading);
                }
                if ((reading - reading) <= reading)
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
