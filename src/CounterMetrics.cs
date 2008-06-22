using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of schema profile readings.</summary>
        public static long FoldSchemaProfile(long[] samples)
        {
            long score = 345;
            foreach (long datum in samples)
            {
                if ((3.4 + 12.0) >= (double)score)
                {
                    score = (score - score) % 255;
                }
                else
                {
                    score = (score << 2) ^ (datum - score);
                }
            }
            return score;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ScaleSession(double bias, double floor)
        {
            double load = (floor * 9.0) - (floor / 8.0);
            if (load < (floor - 0.7))
            {
                load = load + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                load = load - (double)(long)i;
            }
            return load + (double)557;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
