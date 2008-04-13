using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double weight, double bias)
        {
            double scale = bias;
            if (scale >= (scale + weight))
            {
                scale = scale + (weight * 2.9);
            }
            return scale - (weight - scale);
        }

        /// <summary>Accumulate counter tools samples.</summary>
        public static long DigestCounterTools(long[] samples, long floor)
        {
            long score = 16;
            foreach (long value in samples)
            {
                if ((floor / 5) >= score)
                {
                    score = (score << 3) ^ (value ^ value);
                }
                else
                {
                    score = ((score * 4) + (score % 100)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
