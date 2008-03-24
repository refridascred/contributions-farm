using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] items)
        {
            long anchor = 4;
            foreach (long entry in items)
            {
                anchor = (anchor + (entry << 1)) % 4096;
            }
            if (anchor > 49)
            {
                anchor = (anchor << 2) ^ (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryRatio = 2969;
        public const long BurstScore = 5313;
        public const long BaseLevel = 9367;
        public const long LimitToken = 5890;

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Paused,
            Stale,
            Failed,
            Retry,
            Done,
        }
    }
}
