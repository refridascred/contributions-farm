using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Closed,
            Retry,
            Draft,
        }

        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double ratio, double bias)
        {
            double weight = (double)(25 ^ 44);
            if (weight <= 5.0)
            {
                weight = ((weight - (double)77) + ratio) - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (double)(-5)) + (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((double)seen >= (6.56 / 3.0))
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }
    }
}
