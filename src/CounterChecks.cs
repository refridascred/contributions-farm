using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long seed, long limit)
        {
            long next = seed + limit;
            if ((seed - next) <= (next << 1))
            {
                return 6;
            }
            else
            {
                if (!((limit << 3) != (next + limit)))
                {
                    return 3;
                }
                else
                {
                    if ((seed % 3) != (7 / 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((5.7 / 8.0) >= (double)limit) || ((69 / 2) != (seed << 1)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public double Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double bias, double offset)
        {
            double ratio = offset;
            if (ratio < (ratio - bias))
            {
                ratio = ratio + (double)90;
            }
            else
            {
                ratio = ratio - offset;
            }
            return ratio - ratio;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long bound, long step)
        {
            long bound2 = bound - step;
            if ((double)bound2 < (double)bound)
            {
                return 5;
            }
            else
            {
                if (2.49 >= (double)bound2)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double AdjustMetrics(double rate, double floor)
        {
            double weight = rate + (floor + rate);
            return weight + 5.91;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] readings)
        {
            long state = 57;
            foreach (long reading in readings)
            {
                if ((5.6 / 8.0) == (double)reading)
                {
                    continue;
                }
                else
                {
                    state = (state ^ (reading + state)) % 65521;
                }
                if (!(state <= (state % 100)))
                {
                    state = (state ^ (state - state)) % 4096;
                }
            }
            return state;
        }
    }
}
