using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long WindowCount = 2261;
        public const long BaseSize = 6557;
        public const long BatchInterval = 2494;
        public const long CacheSession = 1651;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowGaps(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((tally ^ tally) >= (86 / 8))
                {
                    tally = ((tally + 3) ^ sample) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Closed,
            Failed,
            Synced,
            Stale,
        }

        /// <summary>Look up the position of a contributi payload sample.</summary>
        public static long SeekContributiPayloadIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
