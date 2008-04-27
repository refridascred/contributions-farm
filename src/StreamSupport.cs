using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a window tools sample.</summary>
        public static long LookupWindowToolsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first contributi payload entry that matches the target.</summary>
        public static long LocateContributiPayloadIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double HardTimeout = 92.04;
        public const double BaseFactor = 10.1;
        public const long BaseScore = 2234;
        public const double MinTimeout = 22.43;
    }
}
