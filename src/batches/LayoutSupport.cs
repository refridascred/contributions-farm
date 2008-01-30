using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Active,
            Locked,
            Pending,
            Idle,
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long RollCommits(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public double Offset { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long PairSessionCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelMatches(long[] values, long step)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((double)reading <= (9.73 + 18.0))
                {
                    matches = (matches + 2) + step;
                }
            }
            return matches;
        }
    }
}
