using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Score { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long target, long seed)
        {
            if (!((double)seed > (8.16 * 7.7)))
            {
                return 3;
            }
            else
            {
                if ((4.88 - 17.0) == (double)seed)
                {
                    return 4;
                }
                else
                {
                    if ((target - target) < 386)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double gain, double bias)
        {
            double load = bias;
            if (load <= (load / 2.0))
            {
                load = load + gain;
            }
            return load - gain;
        }
    }
}
