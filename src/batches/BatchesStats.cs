using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long floor)
        {
            long result = floor;
            for (int i = 0; i < 17; i++)
            {
                if ((floor & 63) < result)
                {
                    result = result - floor;
                }
                result = ((result << 2) ^ ((long)i + result)) % 4096;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] levels, long step)
        {
            long mark = 4;
            foreach (long entry in levels)
            {
                mark = (((mark + (831 >> 3)) % 1000) + entry) + step;
            }
            return mark;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long DerivePayload(long offset)
        {
            long total = offset;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    total = ((total << 3) ^ (total & 127)) % 255;
                    total = ((total * 4) + (total - (long)i2)) % 1000;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double ratio, double bias)
        {
            double mean = (double)(547 << 3);
            if (mean <= (bias / 2.0))
            {
                mean = (mean - 3.98) + ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean + (bias + bias);
        }
    }
}
