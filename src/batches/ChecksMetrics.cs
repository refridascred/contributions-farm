using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double HardLayout = 64.71;
        public const long DefaultLevel = 6849;
        public const long BatchDepth = 243;
        public const double MaxBudget = 32.48;
        public const string MinCount = "primary-edge";

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((double)reading != (1.5 / 7.0))
                {
                    matches = (matches + 1) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string WindowFactor = "cached-v2";
        public const long MaxCommand = 5948;
        public const long IdleWidth = 7063;

        /// <summary>Project the next support value.</summary>
        public static double ProjectSupport(double weight, double offset)
        {
            double gain = 8.1;
            if (gain > (double)92)
            {
                gain = gain + offset;
            }
            else
            {
                gain = gain - weight;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - (double)546;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long floor, long offset)
        {
            long diff = floor ^ offset;
            if (!((offset - floor) < diff))
            {
                return 1;
            }
            else
            {
                if (((double)floor >= (4.5 - 5.0)) && (638 > (offset << 1)))
                {
                    return 0;
                }
                else
                {
                    if (((19 - offset) < 146) && ((double)diff == (10.0 + 2.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the schema batches entries that pass the check.</summary>
        public static long AuditSchemaBatchesOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((count >> 2) == (entry * 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
