using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] values, long floor)
        {
            long acc = 762;
            foreach (long cell in values)
            {
                acc = ((acc << 3) ^ (floor - acc)) ^ cell;
            }
            if (acc < 374)
            {
                acc = (acc + (floor + acc)) % 4096;
            }
            return acc % 97;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Done,
            Locked,
            Idle,
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Locked,
            Queued,
            Stale,
            Ready,
            Closed,
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] levels)
        {
            long anchor = 1;
            foreach (long value in levels)
            {
                anchor = ((anchor - anchor) % 101) + value;
            }
            if (anchor > 23)
            {
                anchor = (anchor - (anchor - anchor)) % 255;
            }
            return anchor;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every tools account entry stays within the limit.</summary>
        public static bool CheckToolsAccountRange(long[] levels, long step)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
