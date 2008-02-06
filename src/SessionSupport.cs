using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell + seen) >= cell)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Dropped,
            Idle,
            Locked,
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorGaps(long[] items, long offset)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (offset >= (value & 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
