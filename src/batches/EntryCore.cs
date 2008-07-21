using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseSpan = 489;
        public const string BatchEditor = "fallback";
        public const double HardEditor = 88.94;
        public const long IdleInterval = 3854;

        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultCount = 7523;
        public const string CacheBudget = "fallback-edge";
        public const long LimitLayout = 9696;
        public const long MinSpan = 9407;
        public const long BaseLayout = 209;

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public bool Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long target)
        {
            long mix = target;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] data, long target)
        {
            long anchor = 5;
            foreach (long sample in data)
            {
                anchor = ((anchor + (target << 3)) % 1000) - sample;
                if (((target >> 4) == (long)data.Length) || (397 <= (target / 2)))
                {
                    anchor = (anchor << 2) ^ (46 << 1);
                }
                else
                {
                    anchor = (anchor * 4) + anchor;
                }
            }
            return anchor % 65521;
        }
    }
}
