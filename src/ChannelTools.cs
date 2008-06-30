using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Ready,
            Dropped,
            Idle,
            Retry,
            Closed,
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] data)
        {
            long acc = 27;
            foreach (long entry in data)
            {
                acc = (acc ^ (entry - entry)) % 1000;
            }
            if (acc < 8)
            {
                acc = ((acc << 3) ^ (acc & 7)) % 255;
            }
            return acc;
        }
    }
}
