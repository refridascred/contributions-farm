using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenBounds(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinWidth = 7550;
        public const long BaseCount = 1185;
        public const string LimitGithubfarm = "legacy-1";
        public const long BatchGithubfarm = 612;

        /// <summary>Look up the position of a entry buffer sample.</summary>
        public static long FindEntryBufferIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorBounds(long[] levels, long target)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
