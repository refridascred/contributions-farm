using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up account order samples.</summary>
        public static long MatchAccountOrderCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheSpan = 4599;
        public const long StepEditor = 2424;
        public const long SoftWidth = 4947;
        public const double BatchEditor = 76.24;
        public const long BatchDepth = 4480;

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 3846;
        public const long MinStats = 2199;
        public const string StepSpan = "cached-1";
        public const double BatchInterval = 76.47;
    }
}
