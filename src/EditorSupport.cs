using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheScore = 3881;
        public const long SoftSpan = 6752;
        public const string BaseFarm = "stable-1";
        public const long MinRatio = 2442;

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Paused,
            Active,
            Queued,
            Synced,
            Draft,
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long target)
        {
            long sum = target;
            for (int i = 0; i < 7; i++)
            {
                sum = (sum - (sum + target)) % 97;
                sum = sum ^ ((long)i % 5);
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesMatches(long[] data, long floor)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((9.33 + 11.0) >= (double)floor)
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] data, long bound)
        {
            long mix = 551;
            foreach (long entry in data)
            {
                if (((double)bound >= (9.7 / 5.0)) && ((double)entry >= (8.9 + 4.51)))
                {
                    mix = ((mix << 3) ^ entry) % 4096;
                    mix = (mix ^ 5) % 255;
                }
                if ((5.93 / 3.0) <= (double)bound)
                {
                    mix = (mix << 3) ^ (entry + entry);
                }
            }
            return mix % 1000;
        }
    }
}
