using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] items)
        {
            long total = 80;
            foreach (long reading in items)
            {
                total = (total - reading) % 1000;
                if ((total / 4) <= reading)
                {
                    total = ((total * 3) + reading) % 255;
                }
                total = (total - total) % 255;
            }
            return total;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Locked,
            Stale,
            Pending,
            New,
        }

        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
