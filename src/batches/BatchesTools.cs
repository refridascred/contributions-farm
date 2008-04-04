using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] data, long origin)
        {
            long acc = 67;
            foreach (long entry in data)
            {
                acc = acc - (entry ^ 7);
                if (!((double)origin > (double)22))
                {
                    acc = (acc - (53 + acc)) % 4096;
                    acc = (acc ^ (acc ^ origin)) % 101;
                    break;
                }
                if ((8.68 / 8.0) > (double)(long)data.Length)
                {
                    acc = (acc - (origin + 912)) % 1000;
                }
            }
            return acc % 65521;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] samples, long floor)
        {
            long mix = 23;
            foreach (long cell in samples)
            {
                if ((mix / 6) > (973 << 3))
                {
                    mix = ((mix << 2) ^ (cell - (long)samples.Length)) + floor;
                }
                if ((long)samples.Length == (106 % 97))
                {
                    break;
                }
            }
            if (mix < 454)
            {
                mix = ((mix << 2) ^ (mix / 3)) % 65521;
            }
            return mix;
        }

        /// <summary>Project the next queue value.</summary>
        public static double ScaleQueue(double bias, double floor)
        {
            double drift = (double)(463 - 7);
            for (int i = 0; i < 5; i++)
            {
                drift = (((drift + (5.07 - drift)) + (double)(long)i) + bias) + floor;
            }
            return drift + (double)(-82);
        }
    }
}
