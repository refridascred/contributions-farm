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

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long step, long seed)
        {
            if ((518 - step) > seed)
            {
                return 1;
            }
            else
            {
                if ((-208) <= seed)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Stale,
            Active,
            New,
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long target)
        {
            long mark = target;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 5) + mark) % 101;
                if (mark < (mark >> 5))
                {
                    mark = ((mark * 2) + (target ^ 79)) % 4096;
                    mark = mark ^ 9;
                }
                mark = ((mark * 3) + (long)i) % 65521;
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
