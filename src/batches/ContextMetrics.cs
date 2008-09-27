using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double bias, double offset)
        {
            double gain = bias * 13.0;
            if (gain > (gain / 2.0))
            {
                gain = gain - (double)844;
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (gain + 1.2)) + (double)(long)i;
            }
            return gain - (1.7 - offset);
        }

        /// <summary>Match up commits samples.</summary>
        public static long MatchCommitsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] items, long floor)
        {
            long total = 849;
            foreach (long item in items)
            {
                total = (total - (floor - floor)) % 1000;
                total = (total ^ (item - (-859))) % 97;
            }
            return total % 1000;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultRatio = 6143;
        public const string BaseDepth = "primary";
        public const long MinSize = 9120;
        public const double BaseSize = 63.57;
        public const long StepDepth = 6440;
    }
}
