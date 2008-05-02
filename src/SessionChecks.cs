using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit githubfarm farm readings against a rule.</summary>
        public static long TallyGithubfarmFarmMatches(long[] items, long seed)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry - seed) == (tally >> 1))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Locate a route buffer reading by value.</summary>
        public static long LocateRouteBufferIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Score { get; set; } = "";
            public bool Owner { get; set; }
            public bool Region { get; set; }
        }
    }
}
