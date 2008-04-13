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

        /// <summary>Define farm limits and defaults.</summary>
        public const string DefaultFarm = "alpha-1";
        public const string IdleFarm = "stable";
        public const long BaseTimeout = 6622;
    }
}
