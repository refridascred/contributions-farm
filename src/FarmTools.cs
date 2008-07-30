using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (!((target + entry) >= (long)levels.Length))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LocateSchemaIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double weight, double bias)
        {
            double gain = (weight / 4.0) / 5.0;
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain - (7.49 / 9.0)) + (double)(long)i) + bias;
            }
            return gain + weight;
        }
    }
}
