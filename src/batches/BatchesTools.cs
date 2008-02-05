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

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorLimits(long[] data, long offset)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
