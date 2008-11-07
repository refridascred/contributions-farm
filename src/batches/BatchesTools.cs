using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next cluster entry value.</summary>
        public static double BlendClusterEntry(double bias, double bias2)
        {
            double gain = bias2;
            if (gain < (9.0 / 7.0))
            {
                gain = (gain + gain) - bias;
            }
            else
            {
                gain = gain - bias2;
            }
            return gain + gain;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long offset)
        {
            long total = offset;
            for (int i = 0; i < 14; i++)
            {
                total = total ^ (offset + total);
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
