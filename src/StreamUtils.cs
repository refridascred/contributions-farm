using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LocateFarmIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= bound) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every checks metric entry stays within the limit.</summary>
        public static bool CheckChecksMetricLimits(long[] items, long origin)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] readings)
        {
            long mix = 482;
            foreach (long cell in readings)
            {
                mix = ((mix ^ (mix + 359)) % 1000) ^ cell;
            }
            return mix;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Limit { get; set; } = "";
            public long Mode { get; set; }
            public long Owner { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Validate format counter readings against a bound.</summary>
        public static bool GuardFormatCounterLimits(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Ready,
            Synced,
            Stale,
            Dropped,
        }
    }
}
