using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Score { get; set; }
            public double Offset { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Look up the position of a batches stats sample.</summary>
        public static long FindBatchesStatsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the checks filter entries that pass the check.</summary>
        public static long MeasureChecksFilterOutliers(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((7.0 - 2.94) != (double)matches)
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }
    }
}
