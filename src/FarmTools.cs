using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long OverlapAccountCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two buffer metrics measurements.</summary>
        public static double AdjustBufferMetrics(double scale, double span)
        {
            double load = 6.3;
            for (int i = 0; i < 9; i++)
            {
                load = ((load + (double)(long)i) + scale) - span;
            }
            return load + (load + load);
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
