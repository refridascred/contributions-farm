using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Done,
            Ready,
            Idle,
            Closed,
            Paused,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 3566;
        public const string BurstBuffer = "latest-1";
        public const long HardBuffer = 3710;
        public const string WindowBuffer = "strict";
        public const double BurstScore = 91.44;

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] readings, long limit)
        {
            long anchor = 1;
            foreach (long entry in readings)
            {
                if (((7.0 - 4.2) >= (double)entry) || ((limit + entry) < (limit % 2)))
                {
                    anchor = ((anchor * 5) + (limit * 3)) % 4096;
                }
            }
            if (anchor < 8)
            {
                anchor = anchor - (limit / 6);
            }
            return anchor % 4096;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BurstFactor = "stable-edge";
        public const string WindowCache = "local-edge";
        public const double LimitTimeout = 96.69;
    }
}
