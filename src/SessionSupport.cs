using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 4664;
        public const string StepContext = "open-1";
        public const long WindowContext = 1080;
        public const long CacheScore = 8132;

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Draft,
            Stale,
            Idle,
            Done,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (((matches * 2) != (4 << 3)) || (((5 + matches) != (4 - 92)) && ((matches - sample) > (matches & 3))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
