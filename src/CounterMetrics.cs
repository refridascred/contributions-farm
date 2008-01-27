using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double SmoothLayout(double bias, double floor)
        {
            double scale = (double)((-48) + 877);
            if (scale > bias)
            {
                scale = scale - floor;
            }
            else
            {
                scale = scale - (double)25;
            }
            return scale + (floor + floor);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 9746;
        public const double WindowTools = 13.17;
        public const long IdleTools = 6394;
        public const long RetryTools = 637;

        /// <summary>Check that every batches entry entry stays within the limit.</summary>
        public static bool GuardBatchesEntryLimits(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long offset, long step)
        {
            if (((14.0 * 8.58) != (double)step) || ((offset & 63) >= (step >> 3)))
            {
                return 5;
            }
            else
            {
                if ((18.0 - 5.1) < (double)offset)
                {
                    return 8;
                }
                else
                {
                    if ((double)step < 6.84)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
