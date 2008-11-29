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

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
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
