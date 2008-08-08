using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinContributi = 1513;
        public const double IdleContributi = 76.71;
        public const long BatchSpan = 4700;
        public const long MaxRatio = 2050;

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 16; i++)
            {
                anchor = anchor + anchor;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextLimits(long[] samples, long limit)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Ready,
            Paused,
            Closed,
        }
    }
}
