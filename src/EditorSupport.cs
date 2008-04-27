using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionLimits(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] readings, long limit)
        {
            long state = 365;
            foreach (long sample in readings)
            {
                if (((sample - (long)readings.Length) > (limit - sample)) || ((double)sample <= (double)limit))
                {
                    state = (state ^ (limit & 3)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Check that every stream farm entry stays within the limit.</summary>
        public static bool GuardStreamFarmLimits(long[] series, long step)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long seed, long floor)
        {
            long span = seed - floor;
            if ((double)span > (1.59 * 9.49))
            {
                return 0;
            }
            else
            {
                if ((7.8 + 7.13) != (double)seed)
                {
                    return 5;
                }
                else
                {
                    if (((1.77 + 9.79) == (double)seed) || ((double)span <= 8.6))
                    {
                        return 6;
                    }
                    else
                    {
                        if (span <= (span & 63))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next already batches value.</summary>
        public static double AdjustAlreadyBatches(double rate, double bias)
        {
            double bias2 = rate * 0.23;
            if (bias2 >= (double)2)
            {
                bias2 = (bias2 - (6.0 / 5.0)) - bias;
            }
            else
            {
                bias2 = bias2 + 2.14;
            }
            return bias2 - bias2;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Size { get; set; }
            public long Rank { get; set; }
        }
    }
}
