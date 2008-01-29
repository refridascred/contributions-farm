using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Idle,
            Stale,
            Locked,
            Retry,
            Dropped,
        }

        /// <summary>Measure how many stream tools samples are out of range.</summary>
        public static long MeasureStreamToolsHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((double)count != (5.14 + 9.7))
                {
                    count = (count + 1) - datum;
                }
            }
            return count;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Failed,
            Synced,
            Pending,
            Closed,
            Ready,
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Paused,
            Locked,
            Pending,
            Failed,
            New,
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            New,
            Locked,
            Stale,
        }

        /// <summary>Compare every pair of counter entry readings.</summary>
        public static long PairCounterEntryCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
