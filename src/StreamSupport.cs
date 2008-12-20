using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first metric graph entry that matches the target.</summary>
        public static long FindMetricGraphIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a account format sample.</summary>
        public static long SeekAccountFormatIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleScore = 5593;
        public const double CacheBatch = 38.28;
        public const long IdleDepth = 6435;
        public const long WindowBatch = 104;
        public const string MaxBatch = "staging-1";
    }
}
