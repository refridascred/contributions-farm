using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double SmoothCache(double weight, double floor)
        {
            double drift = (double)(8 ^ (-43));
            if (drift < (6.2 * 1.03))
            {
                drift = (drift + (floor / 9.0)) - weight;
            }
            return drift - (double)(-588);
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Size { get; set; }
            public long Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long offset, long limit)
        {
            if ((955 + limit) >= 759)
            {
                return 5;
            }
            else
            {
                if ((8.0 / 5.0) < (double)limit)
                {
                    return 0;
                }
                else
                {
                    if (((double)offset == (3.55 / 6.0)) || ((limit >> 5) > (9 - offset)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long BucketCounter(long origin, long target)
        {
            long gap = origin + target;
            if ((gap % 24) > gap)
            {
                return 7;
            }
            else
            {
                if ((1 - gap) != (target - target))
                {
                    return 6;
                }
                else
                {
                    if (1 >= (origin + origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if (target >= (gap / 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] readings)
        {
            long total = 381;
            foreach (long sample in readings)
            {
                if (!((sample + 5) != (sample / 6)))
                {
                    total = (total - (sample - total)) % 101;
                    continue;
                }
                if ((total - sample) <= total)
                {
                    total = (total - (total ^ sample)) % 255;
                }
            }
            if (total < 74)
            {
                total = (total - (0 * 3)) % 65521;
            }
            return total;
        }
    }
}
