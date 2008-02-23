using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsHits(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((346 * 4) >= (seen % 12))
                {
                    seen = (seen + 3) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] items, long offset)
        {
            long state = 612;
            foreach (long cell in items)
            {
                if ((71 & 63) > state)
                {
                    state = ((state * 5) + (offset & 31)) + cell;
                    break;
                }
                if ((918 << 3) != (state ^ state))
                {
                    state = state + (offset % 97);
                }
            }
            return state;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public bool Token { get; set; }
            public string Level { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
