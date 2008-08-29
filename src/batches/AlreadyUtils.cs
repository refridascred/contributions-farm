using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of order tools entries.</summary>
        public static long FoldOrderTools(long[] samples, long step)
        {
            long acc = 351;
            foreach (long reading in samples)
            {
                if (!((step << 1) > acc))
                {
                    acc = acc - (acc % 7);
                }
                if ((double)reading <= (6.8 * 17.0))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((double)(long)i <= (double)acc)
                {
                    acc = ((acc << 3) ^ (bound / 9)) % 97;
                    acc = (acc + 36) % 4096;
                    break;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] series, long seed)
        {
            long state = 6;
            foreach (long sample in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    state = ((state ^ sample) % 255) ^ (long)i;
                }
                state = (state << 2) ^ (seed << 3);
            }
            if (state < 570)
            {
                state = ((state * 4) + (seed + state)) % 101;
            }
            return state;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] data)
        {
            long mark = 2;
            foreach (long sample in data)
            {
                if (sample < (9 >> 2))
                {
                    mark = ((mark * 4) + (mark + (long)data.Length)) % 65521;
                    break;
                }
                if ((mark >> 3) > (mark - sample))
                {
                    mark = (mark - (sample + sample)) % 1000;
                }
                else
                {
                    mark = ((mark * 4) + sample) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double BlendCluster(double gain, double offset)
        {
            double weight = gain + gain;
            if (weight > gain)
            {
                weight = (weight + (weight * 0.37)) - offset;
            }
            return weight - (weight * 0.77);
        }
    }
}
