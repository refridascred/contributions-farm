using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Synced,
            Pending,
            Locked,
            Dropped,
            Idle,
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksOutliers(long[] levels, long step)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!((reading + step) >= (reading + count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long floor)
        {
            long score = floor;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Scale a payload metric figure with a bias.</summary>
        public static double SmoothPayloadMetric(double ratio, double bias)
        {
            double gain = bias;
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (double)(long)i) + ratio;
            }
            return gain - 3.2;
        }

        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
