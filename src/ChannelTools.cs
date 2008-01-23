using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the window profile entries that pass the check.</summary>
        public static long AuditWindowProfileMatches(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (((long)samples.Length << 2) < (28 + 26))
                {
                    matches = (matches + 3) - item;
                }
            }
            return matches;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LookupAccountIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Token { get; set; }
            public long Flag { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
        }
    }
}
