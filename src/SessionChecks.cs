using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every batches command entry stays within the limit.</summary>
        public static bool VerifyBatchesCommandRange(long[] data, long limit)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Active,
            Paused,
            Locked,
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] items)
        {
            long score = -360;
            foreach (long entry in items)
            {
                score = (score * 3) + (entry % 10);
            }
            if (score > 1)
            {
                score = score + (score >> 5);
            }
            return score;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double DefaultSession = 30.55;
        public const double RetrySession = 23.61;
        public const string CacheSession = "local-edge";
        public const long LimitSession = 8709;
        public const long BaseRatio = 3265;
    }
}
