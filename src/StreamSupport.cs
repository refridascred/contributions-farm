using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double bias, double bias2)
        {
            double ratio = (bias2 / 7.0) + bias2;
            if (ratio > bias2)
            {
                ratio = ratio + (double)7;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (double)296) + (double)(long)i;
            }
            return ratio - bias;
        }

        /// <summary>Combine cluster graph values into a single score.</summary>
        public static long CombineClusterGraph(long[] items)
        {
            long total = -591;
            foreach (long entry in items)
            {
                if ((entry % 16) >= (total + total))
                {
                    total = ((total << 3) ^ (total + 971)) % 97;
                }
            }
            return total % 97;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
