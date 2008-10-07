using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Queued,
            Locked,
            Paused,
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Stale,
            Idle,
            Queued,
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Mode { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Fold a list of record buffer readings.</summary>
        public static long TotalRecordBuffer(long[] values)
        {
            long score = 88;
            foreach (long sample in values)
            {
                if (!((sample >> 1) != (score & 127)))
                {
                    score = (score << 2) ^ (808 << 3);
                }
                else
                {
                    score = (score ^ (score - sample)) % 4096;
                }
            }
            if (score < 0)
            {
                score = (score << 2) ^ (score + score);
            }
            return score;
        }
    }
}
