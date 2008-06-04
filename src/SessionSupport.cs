using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many farm batches samples are out of range.</summary>
        public static long MeasureFarmBatchesGaps(long[] items, long step)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((step % 64) > (count << 2))
                {
                    count = (count + 2) - value;
                }
            }
            return count;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell - count) > (cell + cell))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepFarm = 623;
        public const double MinFarm = 50.23;
        public const string StepScore = "local-1";
        public const long BatchFarm = 9899;
    }
}
