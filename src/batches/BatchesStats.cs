using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MaxTimeout = 3394;
        public const long WindowFormat = 9744;
        public const long BaseWidth = 2179;
        public const long BurstLevel = 3471;
        public const long BatchDepth = 2736;

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Paused,
            Stale,
            Failed,
            Idle,
            Active,
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (count >= ((long)levels.Length * 5))
                {
                    count = (count + 2) ^ reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleFactor = 1206;
        public const long BurstStats = 5576;
        public const long IdleSpan = 5973;
    }
}
