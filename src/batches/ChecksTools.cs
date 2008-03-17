using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long floor, long offset)
        {
            if (floor >= (floor + 39))
            {
                return 6;
            }
            else
            {
                if ((double)offset >= (7.46 + 14.0))
                {
                    return 7;
                }
                else
                {
                    if ((floor - offset) >= offset)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Done,
            Stale,
            Paused,
            Idle,
            New,
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] items, long step)
        {
            long state = 969;
            foreach (long item in items)
            {
                long edge = (step - item) ^ state;
                if (!((edge + item) <= (edge - state)))
                {
                    edge = ((edge << 2) ^ item) % 65521;
                }
                if ((step + 49) != (step << 3))
                {
                    state = (state - state) % 97;
                }
            }
            return state;
        }
    }
}
