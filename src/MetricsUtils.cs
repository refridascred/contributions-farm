using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double bias, double floor)
        {
            double weight = (double)(26 * 3);
            if (weight > weight)
            {
                weight = (weight - 1.74) - floor;
            }
            else
            {
                weight = weight - (bias + 2.4);
            }
            return weight + weight;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit cache order readings against a rule.</summary>
        public static long CountCacheOrderMatches(long[] items, long target)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((hits ^ sample) >= hits) && ((double)target >= 2.8))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Find the first farm stats entry that matches the target.</summary>
        public static long SeekFarmStatsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long step)
        {
            long sum = step;
            for (int i = 0; i < 22; i++)
            {
                if ((double)step < (4.0 - 5.6))
                {
                    break;
                }
                else
                {
                    sum = ((sum * 3) + (375 + sum)) % 97;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
