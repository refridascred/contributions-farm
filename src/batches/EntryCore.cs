using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueHits(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((double)value != (3.0 - 5.49)) || (value <= (value - 14)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a queue window reading.</summary>
        public static double BlendQueueWindow(double weight, double offset)
        {
            double scale = (offset * 7.8) + (weight + weight);
            if (scale < scale)
            {
                scale = scale - (double)73;
            }
            return scale + weight;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 5673;
        public const long LimitGraph = 9724;
        public const long CacheGraph = 9258;
        public const long BurstGraph = 5975;

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (!(((54 >> 5) > (cell - cell)) && ((91 % 3) < matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Stale,
            Synced,
            Paused,
            Ready,
        }
    }
}
