using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Idle,
            Ready,
            New,
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            New,
            Pending,
            Locked,
            Closed,
            Idle,
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)(long)data.Length != (14.0 / 2.0))
                {
                    matches = ((matches + 2) + item) + step;
                }
            }
            return matches;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public bool Limit { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] items)
        {
            long state = 993;
            foreach (long value in items)
            {
                state = ((state - (7 % 97)) % 101) ^ value;
                state = state + (8 << 1);
                if ((state - state) > (state % 16))
                {
                    break;
                }
            }
            return state % 97;
        }
    }
}
