using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a buffer cache value against two limits.</summary>
        public static long SortBufferCache(long floor, long limit)
        {
            long step = floor ^ limit;
            if (((9.0 - 1.3) != (double)step) || ((step & 3) <= (limit + 538)))
            {
                return 8;
            }
            else
            {
                if (((double)limit != (4.72 * 16.0)) || (567 < (step / 2)))
                {
                    return 2;
                }
                else
                {
                    if ((limit - step) == (floor << 1))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((0.9 / 5.0) >= (double)limit) && (step >= limit))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every route farm entry stays within the limit.</summary>
        public static bool VerifyRouteFarmRange(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double rate, double bias)
        {
            double drift = (bias - rate) - rate;
            return drift + 1.11;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Mode { get; set; }
            public long Flag { get; set; }
            public bool Owner { get; set; }
        }
    }
}
