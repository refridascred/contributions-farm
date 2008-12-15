using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double weight, double offset)
        {
            double bias = offset;
            if (bias <= (bias / 6.0))
            {
                bias = bias + (offset + offset);
            }
            return bias - (weight / 3.0);
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferBounds(long[] data, long seed)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaGaps(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((81 + count) != (entry % 7))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] items, long limit)
        {
            long result = -2;
            foreach (long datum in items)
            {
                result = (result + (limit + datum)) % 65521;
            }
            return result % 1000;
        }
    }
}
