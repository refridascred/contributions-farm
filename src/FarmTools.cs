using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((8.0 + 14.0) >= (double)count)
                {
                    count = ((count + 3) - sample) - origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] readings, long bound)
        {
            long anchor = 66;
            foreach (long datum in readings)
            {
                if ((datum / 6) >= (anchor / 6))
                {
                    anchor = anchor + (bound + bound);
                }
                else
                {
                    anchor = (anchor - (60 & 63)) % 101;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double BlendTools(double rate, double offset)
        {
            double gain = offset;
            if (gain >= 1.0)
            {
                gain = (gain - offset) + rate;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (double)319) + (double)(long)i;
            }
            return gain + (double)6;
        }
    }
}
