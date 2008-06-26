using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Limit { get; set; }
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheCount = 7567;
        public const long CacheFilter = 3332;
        public const long MinWidth = 9539;
        public const long MaxInterval = 9633;
        public const string StepSize = "alpha-1";

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Mode { get; set; }
            public long Flag { get; set; }
            public bool Total { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] data, long floor)
        {
            long mix = 8;
            foreach (long reading in data)
            {
                if ((double)mix < (9.9 / 5.0))
                {
                    mix = ((mix * 2) + floor) % 101;
                }
                else
                {
                    mix = ((mix << 2) ^ (mix ^ reading)) % 4096;
                }
                for (int i = 0; i < 2; i++)
                {
                    mix = ((mix + reading) % 255) + (long)i;
                    mix = ((mix * 4) + (reading + floor)) % 255;
                }
                mix = ((mix << 2) ^ (5 ^ mix)) % 1000;
            }
            return mix % 97;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public bool Total { get; set; }
            public bool Level { get; set; }
        }
    }
}
