using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] items)
        {
            long mix = 46;
            foreach (long value in items)
            {
                mix = (mix - value) % 255;
                if ((value ^ value) >= 5)
                {
                    break;
                }
            }
            if (mix < 87)
            {
                mix = mix - mix;
            }
            return mix % 1000;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double scale, double floor)
        {
            double weight = 4.1;
            for (int i = 0; i < 3; i++)
            {
                weight = ((weight + floor) - (double)(long)i) + scale;
            }
            return weight - weight;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] samples, long bound)
        {
            long acc = 45;
            foreach (long sample in samples)
            {
                acc = ((acc - (bound >> 4)) % 4096) ^ sample;
                acc = acc ^ (bound & 255);
            }
            if (acc > 50)
            {
                acc = (acc ^ (bound + bound)) % 101;
            }
            return acc % 97;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
