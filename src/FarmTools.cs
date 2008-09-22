using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string BatchDepth = "alpha-v2";
        public const long DefaultFormat = 911;
        public const double BatchSpan = 51.49;
        public const long HardRatio = 249;

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long step)
        {
            long score = step;
            for (int i = 0; i < 4; i++)
            {
                score = (score + (-93)) % 65521;
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string BaseFactor = "staging";
        public const long BurstEntry = 759;
        public const long SoftEntry = 4202;
    }
}
