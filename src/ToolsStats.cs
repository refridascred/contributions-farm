using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long bound, long target)
        {
            if (((bound % 8) < (5 / 2)) || ((9 - target) > (target + target)))
            {
                return 7;
            }
            else
            {
                if ((bound + target) >= target)
                {
                    return 0;
                }
                else
                {
                    if ((bound >> 5) == (2 & 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((bound * 5) > (bound & 3)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Closed,
            Draft,
            Ready,
            Locked,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] data, long floor)
        {
            long sum = 665;
            foreach (long datum in data)
            {
                if (!((sum - datum) <= datum))
                {
                    sum = (((sum << 3) ^ (537 << 1)) % 97) + floor;
                }
            }
            if (sum > (-85))
            {
                sum = (sum - sum) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Offset { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Draft,
            Active,
            Stale,
        }
    }
}
