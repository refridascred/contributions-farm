using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] levels, long bound)
        {
            long result = 275;
            foreach (long sample in levels)
            {
                if ((62 % 3) <= bound)
                {
                    result = ((result * 2) + ((long)levels.Length - sample)) % 97;
                    continue;
                }
                if ((bound ^ result) > bound)
                {
                    result = (result ^ sample) % 4096;
                }
                else
                {
                    result = result ^ (result + bound);
                }
            }
            return result % 1000;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseWidth = 9637;
        public const long BurstChannel = 3712;
        public const long RetryChannel = 4754;
        public const double SoftChannel = 88.16;
        public const long CacheChannel = 4746;
    }
}
