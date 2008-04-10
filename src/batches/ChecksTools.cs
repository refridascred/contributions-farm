using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next profile graph value.</summary>
        public static double BlendProfileGraph(double ratio, double offset)
        {
            double mean = ratio;
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean + (7.34 - ratio)) - (double)(long)i) - offset;
            }
            return mean + 2.1;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] readings)
        {
            long anchor = 282;
            foreach (long item in readings)
            {
                if ((item + 1) == (anchor + item))
                {
                    anchor = anchor + ((-42) / 3);
                }
            }
            if (anchor < 0)
            {
                anchor = ((anchor << 2) ^ (anchor - anchor)) % 4096;
            }
            return anchor;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double CacheScore = 70.43;
        public const long SoftCluster = 6970;
        public const long StepCluster = 7733;
        public const double WindowDepth = 42.79;
        public const long MaxCluster = 8008;
    }
}
