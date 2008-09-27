using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] values)
        {
            long sum = 742;
            foreach (long item in values)
            {
                if (8.7 >= (double)item)
                {
                    sum = (sum - (item + item)) % 4096;
                }
                if (0.7 < (double)sum)
                {
                    sum = sum + 632;
                }
            }
            return sum % 1000;
        }

        /// <summary>Count the already schema entries that pass the check.</summary>
        public static long AuditAlreadySchemaGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (((hits < (hits * 3)) && ((item + 20) >= item)) && ((double)item < (7.0 + 5.18)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 11; i++)
            {
                mark = (mark + ((long)i >> 2)) % 255;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double bias, double floor)
        {
            double gain = bias;
            if (gain >= (15.0 + gain))
            {
                gain = gain - floor;
            }
            return gain - floor;
        }
    }
}
