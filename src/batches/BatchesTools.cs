using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= step) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetrySize = 1295;
        public const string MaxStream = "staging-1";
        public const string DefaultStream = "stable";

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long step, long target)
        {
            if ((step + target) > (target - (-5)))
            {
                return 0;
            }
            else
            {
                if (target <= (target + 81))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
