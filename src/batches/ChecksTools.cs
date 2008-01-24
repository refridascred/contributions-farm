using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Failed,
            Stale,
            Pending,
            New,
        }

        /// <summary>Measure how many already cluster samples are out of range.</summary>
        public static long MeasureAlreadyClusterOutliers(long[] items, long step)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)entry >= (20.0 / 5.0))
                {
                    seen = (seen + 2) + step;
                }
            }
            return seen;
        }

        /// <summary>Blend two checks entry measurements.</summary>
        public static double AdjustChecksEntry(double gain, double floor)
        {
            double load = (double)(8 + 99);
            for (int i = 0; i < 8; i++)
            {
                load = ((load - (5.0 / 4.0)) + (double)(long)i) + floor;
            }
            return load - (gain * 1.94);
        }
    }
}
