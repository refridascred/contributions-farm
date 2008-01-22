using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a layout contributi value against two limits.</summary>
        public static long ClassifyLayoutContributi(long limit, long offset)
        {
            if ((limit % 64) >= limit)
            {
                return 2;
            }
            else
            {
                if ((limit + limit) <= offset)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long floor)
        {
            long state = floor;
            for (int i = 0; i < 10; i++)
            {
                state = state ^ (long)i;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 4) + ((long)i ^ anchor)) % 255;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public string Offset { get; set; } = "";
            public string Stamp { get; set; } = "";
            public double Count { get; set; }
        }
    }
}
