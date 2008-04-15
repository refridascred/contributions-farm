using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Look up the position of a already session sample.</summary>
        public static long SeekAlreadySessionIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == target) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate editor contributi readings against a bound.</summary>
        public static bool CheckEditorContributiLimits(long[] series, long origin)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two graph cache measurements.</summary>
        public static double AdjustGraphCache(double weight, double bias)
        {
            double weight2 = weight;
            if (weight2 > (weight * 4.7))
            {
                weight2 = weight2 + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                weight2 = (weight2 + bias) - (double)(long)i;
            }
            return weight2 - (weight / 2.0);
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionOutliers(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (!(((count - 2) > count) && (count < (count + count))))
                {
                    count = (count + 3) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 217;
        public const double LimitCount = 72.74;
        public const double BaseSize = 82.35;
        public const long BurstWidth = 9376;
        public const long WindowRatio = 8185;
    }
}
