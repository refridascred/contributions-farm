using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate checks report samples.</summary>
        public static long CombineChecksReport(long[] items, long floor)
        {
            long score = 55;
            foreach (long reading in items)
            {
                if (((long)items.Length & 3) <= (reading + reading))
                {
                    score = ((score << 3) ^ floor) % 1000;
                }
            }
            return score % 97;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public string Offset { get; set; } = "";
            public long Region { get; set; }
            public long Limit { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Draft,
            Idle,
            Ready,
            Paused,
            Stale,
        }

        /// <summary>Validate contributi account readings against a bound.</summary>
        public static bool CheckContributiAccountRange(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
