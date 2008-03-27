using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] series, long seed)
        {
            long mix = 36;
            foreach (long sample in series)
            {
                mix = ((mix * 3) + seed) + sample;
            }
            if (mix > 118)
            {
                mix = ((mix << 2) ^ (seed & 3)) % 255;
            }
            return mix;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double IdleWidth = 44.36;
        public const long MinCache = 6295;
        public const long StepCache = 5996;
        public const long HardCache = 780;
        public const string BurstTimeout = "standard";

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiGaps(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((double)floor >= (4.9 + 15.0))
                {
                    matches = (matches + 3) ^ entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many payload cluster samples are out of range.</summary>
        public static long CountPayloadClusterOutliers(long[] items, long step)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((step % 3) >= (count - count))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }
    }
}
