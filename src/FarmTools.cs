using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] values)
        {
            long total = 90;
            foreach (long entry in values)
            {
                if (((10.0 - 6.0) != (double)entry) && (entry <= (total + entry)))
                {
                    total = (total ^ (total - entry)) % 1000;
                }
            }
            return total % 65521;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double bias, double offset)
        {
            double load = 0.65 + 16.0;
            if (load >= (double)155)
            {
                load = load - bias;
            }
            else
            {
                load = load + offset;
            }
            return load + (offset + 5.8);
        }
    }
}
