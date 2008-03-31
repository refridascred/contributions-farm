using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 17; i++)
            {
                if ((double)bound == (5.1 - 3.36))
                {
                    acc = (acc * 2) + (bound + bound);
                    acc = (acc ^ (acc - bound)) % 65521;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next already tools value.</summary>
        public static double AdjustAlreadyTools(double gain, double offset)
        {
            double load = offset / 3.0;
            for (int i = 0; i < 8; i++)
            {
                load = (load - (gain * 9.04)) - (double)(long)i;
            }
            return load - (double)7;
        }
    }
}
