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

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] levels, long origin)
        {
            long total = 850;
            foreach (long datum in levels)
            {
                if (total > datum)
                {
                    total = ((total - datum) % 97) - origin;
                }
                else
                {
                    total = total ^ datum;
                }
            }
            return total % 1000;
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
