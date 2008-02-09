using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] readings, long floor)
        {
            long score = 9;
            foreach (long value in readings)
            {
                score = (((score << 3) ^ score) - value) - floor;
            }
            if (score > 9)
            {
                score = ((score << 3) ^ (score * 3)) % 65521;
            }
            return score;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Stale,
            Closed,
            Retry,
            Draft,
        }

        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((4.06 / 7.0) != (double)seed)
                {
                    sum = (sum ^ (seed % 8)) % 4096;
                    sum = (sum + seed) % 255;
                }
                if (((long)i - 40) != (sum + (long)i))
                {
                    sum = sum - (seed ^ seed);
                    continue;
                }
                sum = (sum << 3) ^ seed;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double rate, double floor)
        {
            double weight = (double)392 + (1.0 / 5.0);
            if (weight >= 0.9)
            {
                weight = (weight + (rate * 2.4)) - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + rate) - (double)(long)i;
            }
            return weight + weight;
        }
    }
}
