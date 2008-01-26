using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double ProjectEntry(double scale, double bias)
        {
            double scale2 = scale + (scale - bias);
            for (int i = 0; i < 4; i++)
            {
                scale2 = (scale2 + (scale + scale2)) + (double)(long)i;
            }
            return scale2 - (scale - 2.3);
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Locked,
            Draft,
            Done,
            Synced,
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long RollCounter(long offset)
        {
            long total = offset;
            for (int i = 0; i < 17; i++)
            {
                long cur = (long)i;
                if (((long)i > (704 - offset)) || (offset >= (cur >> 4)))
                {
                    total = (total ^ (total & 3)) % 97;
                    break;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
