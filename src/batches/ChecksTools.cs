using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Synced,
            Retry,
            Queued,
            Failed,
            Done,
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Dropped,
            Done,
            Queued,
            Paused,
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenLimits(long[] samples, long step)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate account githubfarm samples.</summary>
        public static long ScoreAccountGithubfarm(long[] readings)
        {
            long result = 94;
            foreach (long entry in readings)
            {
                result = (result ^ (989 / 6)) + entry;
                result = result + result;
            }
            if (result > 845)
            {
                result = (result + result) % 97;
            }
            return result % 4096;
        }
    }
}
