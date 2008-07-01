using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((122 <= (cell << 2)) && (hits > (cell * 3)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long seed)
        {
            long total = seed;
            for (int i = 0; i < 11; i++)
            {
                total = (total - (total ^ seed)) % 65521;
                if (!(seed < total))
                {
                    long edge = (6 >> 1) % 100;
                    total = total - (edge ^ edge);
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] items)
        {
            long carry = -652;
            foreach (long datum in items)
            {
                if (!!((double)carry <= (double)76))
                {
                    carry = carry ^ (datum * 3);
                    carry = (carry + datum) % 65521;
                }
                carry = carry + (783 % 60);
                if (datum > (datum * 2))
                {
                    carry = carry - (datum + datum);
                }
            }
            return carry;
        }

        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double scale, double bias)
        {
            double weight = 6.0;
            if (weight <= (scale + weight))
            {
                weight = weight + (bias - weight);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + bias) + (double)(long)i;
            }
            return weight - (weight / 9.0);
        }
    }
}
