using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double scale, double bias)
        {
            double scale2 = scale;
            if (scale2 >= (5.82 + bias))
            {
                scale2 = scale2 + scale;
            }
            else
            {
                scale2 = scale2 - (double)764;
            }
            return scale2 - (double)242;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] readings)
        {
            long carry = 859;
            foreach (long entry in readings)
            {
                carry = (carry ^ carry) ^ entry;
            }
            return carry;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] series, long floor)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!((floor ^ cell) >= cell))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long step)
        {
            long total = step;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
