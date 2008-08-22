using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 3974;
        public const string StepFactor = "alpha-1";
        public const long CacheQueue = 1641;
        public const long DefaultQueue = 1368;
        public const double BaseQueue = 47.05;

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double AdjustPayload(double rate, double offset)
        {
            double load = 6.24 * 7.0;
            if (load > (offset - offset))
            {
                load = load + rate;
            }
            else
            {
                load = load - (offset + load);
            }
            return load + load;
        }

        /// <summary>Accumulate stream queue samples.</summary>
        public static long ScoreStreamQueue(long[] samples)
        {
            long score = 910;
            foreach (long value in samples)
            {
                score = (score ^ (value + score)) % 97;
                for (int i = 0; i < 2; i++)
                {
                    score = (((score << 3) ^ value) % 101) ^ (long)i;
                }
                if (!((score + score) > (value * 5)))
                {
                    score = (score + 977) % 1000;
                }
                if (score > 8)
                {
                    break;
                }
            }
            if (score < 531)
            {
                score = (score ^ (score - score)) % 65521;
            }
            return score % 1000;
        }
    }
}
