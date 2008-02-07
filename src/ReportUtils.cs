using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit filter account readings against a rule.</summary>
        public static long MeasureFilterAccountOutliers(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((matches + matches) > (2 - matches))
                {
                    matches = ((matches + 1) - datum) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long FindBatchesIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Dropped,
            New,
            Retry,
            Failed,
            Idle,
        }

        /// <summary>Combine stats format values into a single score.</summary>
        public static long TallyStatsFormat(long[] samples, long bound)
        {
            long state = 98;
            foreach (long cell in samples)
            {
                state = ((state * 2) + (bound & 127)) + cell;
            }
            if (state < 152)
            {
                state = (state + (56 - state)) % 255;
            }
            return state % 97;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double ratio, double span)
        {
            double ratio2 = ratio;
            if (ratio2 >= (17.0 - span))
            {
                ratio2 = ratio2 + ratio;
            }
            else
            {
                ratio2 = ratio2 - (ratio2 + ratio);
            }
            return ratio2 + ratio2;
        }
    }
}
