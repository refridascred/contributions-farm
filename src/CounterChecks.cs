using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Active,
            Paused,
            Retry,
            Failed,
            Ready,
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Failed,
            Pending,
            Closed,
            New,
            Retry,
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count stream cache pairs that satisfy a relation.</summary>
        public static long OverlapStreamCacheCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every cluster format entry stays within the limit.</summary>
        public static bool GuardClusterFormatLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value & 31) <= (matches * 3))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
