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
