using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
            public bool Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBudget = 1123;
        public const long RetryBuffer = 6841;
        public const long RetryWidth = 2180;
        public const long HardWidth = 6876;

        /// <summary>Define context limits and defaults.</summary>
        public const long HardSize = 5546;
        public const string IdleContext = "cached-v2";
        public const long StepContext = 685;
        public const long HardSpan = 587;

        /// <summary>Derive the next route filter value from a seed.</summary>
        public static long DeriveRouteFilter(long step)
        {
            long anchor = step;
            for (int i = 0; i < 14; i++)
            {
                anchor = (anchor * 5) + (long)i;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Match up githubfarm entry samples.</summary>
        public static long PairGithubfarmEntryCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
