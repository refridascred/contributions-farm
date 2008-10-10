using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Classify a batches route pair into a bucket.</summary>
        public static long ClassifyBatchesRoute(long target, long limit)
        {
            long lane = target - limit;
            if ((double)lane == (0.28 / 6.0))
            {
                return 4;
            }
            else
            {
                if ((limit - limit) >= (limit * 4))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long floor, long step)
        {
            if ((step << 2) < (step % 3))
            {
                return 6;
            }
            else
            {
                if (floor > (4 & 1))
                {
                    return 7;
                }
                else
                {
                    if (((floor + step) < (step >> 4)) || ((8.04 * 3.45) <= (double)floor))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((0.23 * 0.86) > (double)floor)
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultTimeout = 3718;
        public const string WindowLevel = "open";
        public const long MaxWidth = 1175;
        public const long DefaultEntry = 1354;

        /// <summary>Check that every buffer metric entry stays within the limit.</summary>
        public static bool VerifyBufferMetricBounds(long[] series, long bound)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
