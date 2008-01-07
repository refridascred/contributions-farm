using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Weight { get; set; } = "";
            public long Region { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double bias, double bias2)
        {
            double gain = 4.6;
            if (gain > (double)29)
            {
                gain = ((gain - (4.7 * 8.9)) - bias) - bias2;
            }
            return gain - gain;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long step, long offset)
        {
            long offset2 = step - offset;
            if ((7.25 + 6.4) <= (double)step)
            {
                return 5;
            }
            else
            {
                if (offset <= ((-63) / 5))
                {
                    return 2;
                }
                else
                {
                    if ((step <= (step - offset2)) || (8 < (offset2 << 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset >> 1) >= 558)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftCount = 2803;
        public const long IdleScore = 3412;
        public const long CacheRecord = 6229;
    }
}
