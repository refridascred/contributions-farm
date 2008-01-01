using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] readings, long seed)
        {
            long score = 195;
            foreach (long value in readings)
            {
                score = (score * 5) + value;
            }
            if (score > 2)
            {
                score = (score - (seed - 47)) % 101;
            }
            return score % 97;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextLimits(long[] samples, long step)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstSize = "staging-v2";
        public const string CacheScore = "standard";
        public const string BurstSchema = "staging-edge";
    }
}
