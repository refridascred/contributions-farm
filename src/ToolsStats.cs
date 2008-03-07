using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long target, long step)
        {
            long diff = target + step;
            if ((step > target) && ((0.3 - 4.0) >= (double)step))
            {
                return 8;
            }
            else
            {
                if ((step + target) <= diff)
                {
                    return 3;
                }
                else
                {
                    if ((8.2 / 9.0) > (double)step)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string WindowBatches = "latest-v2";
        public const string IdleBatches = "primary-1";
        public const double WindowScore = 71.48;
        public const long BaseBatches = 97;

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutBounds(long[] data, long seed)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 4911;
        public const long BatchQueue = 1463;
        public const double IdleQueue = 30.3;

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Idle,
            New,
            Active,
            Locked,
            Queued,
        }

        /// <summary>Project the next already value.</summary>
        public static double AdjustAlready(double weight, double floor)
        {
            double rate = (weight + weight) - floor;
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - (rate - weight)) + (double)(long)i;
            }
            return rate - floor;
        }
    }
}
