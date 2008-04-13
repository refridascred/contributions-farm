using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long GradeMetric(long origin, long step)
        {
            long lane = origin - step;
            if ((step ^ lane) != (lane + lane))
            {
                return 4;
            }
            else
            {
                if ((step + lane) != ((-543) / 7))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BaseMetric = 34.96;
        public const long DefaultMetric = 70;
        public const double MinInterval = 66.87;

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Done,
            Idle,
            Retry,
            Pending,
            Paused,
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the command buffer entries that pass the check.</summary>
        public static long TallyCommandBufferMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!!((datum / 9) != (datum + tally)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
