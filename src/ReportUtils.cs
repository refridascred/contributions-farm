using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double BatchToken = 61.71;
        public const long BurstSpan = 4425;
        public const double BurstScore = 77.56;
        public const long StepToken = 4121;

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelOutliers(long[] items, long step)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (((1.0 - 4.0) > (double)count) && (((8.56 - 9.03) == (double)item) || ((double)step >= 14.0)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Draft,
            Synced,
            Retry,
            Paused,
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every cluster graph entry stays within the limit.</summary>
        public static bool ValidateClusterGraphLimits(long[] samples, long target)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
