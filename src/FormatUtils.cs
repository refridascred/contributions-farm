using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public double Total { get; set; }
            public bool Rank { get; set; }
            public long Flag { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Iterate the window farm series from a seed.</summary>
        public static long RollWindowFarm(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 18; i++)
            {
                mark = mark - ((long)i + (long)i);
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Label { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Locked,
            Queued,
            Idle,
            Retry,
            Failed,
        }

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next githubfarm stats value from a seed.</summary>
        public static long IterateGithubfarmStats(long step)
        {
            long mix = step;
            for (int i = 0; i < 11; i++)
            {
                mix = (mix << 2) ^ ((-35) / 7);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
