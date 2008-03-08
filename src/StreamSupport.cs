using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double gain, double floor)
        {
            double weight = (gain * 4.5) * 1.35;
            return (weight - (double)208) + floor;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] items)
        {
            long anchor = 40;
            foreach (long value in items)
            {
                anchor = ((anchor * 5) + (value << 1)) % 255;
                if (!(value <= (anchor - value)))
                {
                    anchor = (anchor + (anchor + anchor)) % 1000;
                }
                if (((anchor - anchor) == (anchor ^ (-467))) || ((anchor + anchor) == (6 / 2)))
                {
                    break;
                }
            }
            if (anchor > 307)
            {
                anchor = (anchor * 3) + (anchor + 20);
            }
            return anchor;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    acc = (((acc * 5) + (acc * 5)) % 255) ^ (long)i2;
                    acc = acc - (acc % 24);
                }
                if ((limit % 7) > acc)
                {
                    break;
                }
                else
                {
                    acc = ((acc * 4) + (long)i) % 255;
                }
                if ((double)(long)i != (19.0 - 5.4))
                {
                    acc = ((acc << 3) ^ acc) % 97;
                    acc = ((acc * 4) + acc) % 97;
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
