using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Compare every pair of stream readings.</summary>
        public static long MatchStreamCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next account value.</summary>
        public static double ProjectAccount(double gain, double bias)
        {
            double weight = (double)(0 * 5);
            if (weight <= (weight + gain))
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - 5.93) + (double)(long)i;
            }
            return weight - bias;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] items, long limit)
        {
            long acc = 81;
            foreach (long sample in items)
            {
                if (!((sample + acc) > acc))
                {
                    acc = (acc * 4) + (limit % 100);
                }
            }
            if (acc > 52)
            {
                acc = (acc + (acc % 12)) % 4096;
            }
            return acc;
        }

        /// <summary>Audit profile graph readings against a rule.</summary>
        public static long MeasureProfileGraphGaps(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((double)entry < (4.8 + 6.61)) && ((entry << 3) < (count + count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Iterate the schema entry series from a seed.</summary>
        public static long SeriesSchemaEntry(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 4) + acc) % 255;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
