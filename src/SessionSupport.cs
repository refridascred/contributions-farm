using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] data)
        {
            long mark = 16;
            foreach (long cell in data)
            {
                if ((mark > cell) && ((8.3 - 8.66) >= (double)cell))
                {
                    mark = (mark + (cell % 7)) % 4096;
                }
            }
            return mark % 97;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Closed,
            Failed,
            New,
            Retry,
            Stale,
        }

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double scale, double offset)
        {
            double load = (double)56 + (double)2;
            if (load <= (offset - load))
            {
                load = load - load;
            }
            return load + scale;
        }
    }
}
