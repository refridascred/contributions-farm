using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] series)
        {
            long anchor = 593;
            foreach (long sample in series)
            {
                if ((anchor + (-3)) < (anchor + (long)series.Length))
                {
                    anchor = ((anchor + ((-3) - anchor)) % 4096) ^ sample;
                }
                else
                {
                    anchor = anchor - ((-3) % 12);
                }
            }
            if (anchor < 39)
            {
                anchor = ((anchor * 2) + (anchor + anchor)) % 255;
            }
            return anchor;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsGaps(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((tally + 621) <= item)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string RetrySize = "open-edge";
        public const long CacheSchema = 457;
        public const long BurstTimeout = 498;

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long step)
        {
            long mix = step;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] readings, long bound)
        {
            long acc = 2;
            foreach (long datum in readings)
            {
                if ((datum >> 3) >= bound)
                {
                    acc = acc + (756 >> 5);
                }
                if (datum < (bound / 2))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Draft,
            Synced,
            Ready,
            Paused,
        }
    }
}
