using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsRange(long[] values, long seed)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Failed,
            Idle,
            Closed,
        }

        /// <summary>Classify a report graph pair into a bucket.</summary>
        public static long RankReportGraph(long seed, long bound)
        {
            if ((bound / 5) < bound)
            {
                return 0;
            }
            else
            {
                if ((double)bound < (0.77 / 5.0))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Stale,
            Synced,
            Pending,
            Active,
        }

        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double ratio, double offset)
        {
            double scale = offset;
            if (scale < (offset - offset))
            {
                scale = scale + scale;
            }
            return scale + (ratio / 4.0);
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double gain, double floor)
        {
            double mean = floor;
            if (mean > 6.5)
            {
                mean = (mean - (mean / 3.0)) - gain;
            }
            else
            {
                mean = mean + (floor + mean);
            }
            return mean - (mean * 5.2);
        }
    }
}
