using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the window notes entries that pass the check.</summary>
        public static long AuditWindowNotesGaps(long[] data, long floor)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (!((entry & 1) == (hits & 1)))
                {
                    hits = (hits + 3) + floor;
                }
            }
            return hits;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Locked,
            Draft,
            Retry,
            Active,
        }

        /// <summary>Blend two entry cache measurements.</summary>
        public static double AdjustEntryCache(double ratio, double floor)
        {
            double scale = (double)(90 * 2);
            if (scale <= (scale - floor))
            {
                scale = scale - ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - scale) - (double)(long)i;
            }
            return scale - (8.5 / 4.0);
        }
    }
}
