using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long limit, long offset)
        {
            long slot = limit ^ offset;
            if (!((500 % 60) > offset))
            {
                return 8;
            }
            else
            {
                if ((limit > (offset * 3)) && ((8.4 / 2.0) > (double)limit))
                {
                    return 7;
                }
                else
                {
                    if ((92 + slot) > (limit << 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionMatches(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!((0.15 - 6.09) < (double)count))
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }

        /// <summary>Adjust a editor record reading.</summary>
        public static double SmoothEditorRecord(double bias, double offset)
        {
            double drift = offset;
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (double)271) - (double)(long)i;
            }
            return drift - (drift + bias);
        }
    }
}
