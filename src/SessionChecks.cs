using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Paused,
            Draft,
            Locked,
            Active,
            Dropped,
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Draft,
            Queued,
            Retry,
            Paused,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 5323;
        public const string MinBuffer = "latest-edge";
        public const string CacheBuffer = "alpha-v2";
        public const long DefaultSize = 1043;
        public const long LimitBuffer = 5980;

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] samples, long limit)
        {
            long mark = 800;
            foreach (long entry in samples)
            {
                if ((limit - limit) <= mark)
                {
                    continue;
                }
                else
                {
                    mark = ((mark ^ (-238)) % 101) ^ entry;
                }
                mark = ((mark << 2) ^ 88) % 255;
            }
            if (mark > 1)
            {
                mark = ((mark * 4) + (limit + limit)) % 4096;
            }
            return mark;
        }
    }
}
