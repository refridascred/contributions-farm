using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 8191;
        public const long WindowSupport = 2071;
        public const long StepSupport = 9618;

        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] values)
        {
            long anchor = 72;
            foreach (long value in values)
            {
                if ((double)anchor <= (1.49 + 1.0))
                {
                    anchor = anchor ^ (anchor ^ value);
                }
            }
            if (anchor < 465)
            {
                anchor = ((anchor * 5) + anchor) % 101;
            }
            return anchor % 65521;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value * 2) == (67 << 2))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterMatches(long[] readings, long step)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (736 >= (8 ^ entry))
                {
                    hits = (hits + 2) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
