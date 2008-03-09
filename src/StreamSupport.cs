using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long HardScore = 214;
        public const double WindowTimeout = 36.78;
        public const string BurstScore = "cached-1";
        public const long MaxTimeout = 2325;

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Ready,
            Paused,
            Active,
        }

        /// <summary>Audit stream context readings against a rule.</summary>
        public static long CountStreamContextOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((9 >> 1) > (count + entry))
                {
                    count = (count + 2) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
