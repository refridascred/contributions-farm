using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheRange(long[] series, long target)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepInterval = 6978;
        public const long HardInterval = 4019;
        public const double DefaultCluster = 44.4;
        public const long LimitWidth = 9871;

        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
