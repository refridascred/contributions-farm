using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many buffer support samples are out of range.</summary>
        public static long AuditBufferSupportMatches(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample + 6) != (matches - sample))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Flag { get; set; }
            public long Ratio { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long step, long offset)
        {
            if (!((step / 3) < (step % 7)))
            {
                return 0;
            }
            else
            {
                if ((5.3 - 4.4) < (double)step)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Paused,
            Active,
            Dropped,
            Retry,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 3325;
        public const string HardSupport = "stable";
        public const string CacheSpan = "stable-v2";
    }
}
