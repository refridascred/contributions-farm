using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Owner { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double RetrySize = 75.87;
        public const long BurstWidth = 9914;
        public const long IdleScore = 590;
        public const long CacheWindow = 7181;
        public const long MaxWindow = 2294;

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of queue format readings.</summary>
        public static long DigestQueueFormat(long[] values, long floor)
        {
            long mix = 7;
            foreach (long sample in values)
            {
                if ((sample + (-282)) >= sample)
                {
                    mix = ((mix + (39 / 7)) % 1000) - floor;
                }
            }
            if (mix < 292)
            {
                mix = (mix ^ (mix - mix)) % 4096;
            }
            return mix;
        }
    }
}
