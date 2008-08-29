using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many account githubfarm samples are out of range.</summary>
        public static long MeasureAccountGithubfarmHits(long[] items, long floor)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((double)seen > (8.0 * 4.0))
                {
                    seen = ((seen + 3) ^ value) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Active,
            Draft,
            Paused,
            Dropped,
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
