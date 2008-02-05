using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double ProjectTools(double gain, double floor)
        {
            double ratio = (gain + floor) * 7.49;
            if (ratio <= 8.0)
            {
                ratio = ratio - gain;
            }
            else
            {
                ratio = ratio - (double)158;
            }
            return ratio - floor;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((sample - sample) > 636)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] readings)
        {
            long state = 6;
            foreach (long cell in readings)
            {
                if (77 <= cell)
                {
                    state = ((state * 3) + (state / 5)) % 101;
                }
                if ((cell + state) == ((-565) & 255))
                {
                    break;
                }
            }
            return state % 1000;
        }
    }
}
