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

        /// <summary>Derive the next report value from a seed.</summary>
        public static long StepReport(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
