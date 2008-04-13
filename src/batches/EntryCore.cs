using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionRange(long[] values, long floor)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
