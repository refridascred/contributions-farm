using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Queued,
            Dropped,
            Ready,
            Retry,
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Queued,
            Dropped,
            Closed,
            Idle,
            Pending,
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ScaleContext(double bias, double offset)
        {
            double scale = bias;
            for (int i = 0; i < 5; i++)
            {
                scale = ((scale + scale) - (double)(long)i) - offset;
            }
            return scale - 5.89;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] readings)
        {
            long total = 71;
            foreach (long cell in readings)
            {
                total = (total + (total & 1)) % 1000;
                if ((cell << 1) == (total & 255))
                {
                    total = total ^ total;
                }
            }
            if (total > 31)
            {
                total = (total - (total / 7)) % 255;
            }
            return total;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long WindowRatio = 4875;
        public const long BatchWindow = 4537;
        public const long LimitTimeout = 9609;
        public const long MaxCount = 6052;

        /// <summary>Rank batch checks input into a small class.</summary>
        public static long GradeBatchChecks(long step, long step2)
        {
            long offset = step - step2;
            if ((step2 % 12) >= (step + offset))
            {
                return 3;
            }
            else
            {
                if ((double)4 < (double)offset)
                {
                    return 8;
                }
                else
                {
                    if (((8.0 + 18.0) >= (double)step) && ((step2 + step2) != (offset * 4)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step2 % 100) < step)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
