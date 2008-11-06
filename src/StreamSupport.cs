using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheScore = 4161;
        public const long MaxTimeout = 5654;
        public const long IdleBuffer = 6351;
        public const double MaxSize = 76.69;
        public const long BatchBuffer = 9761;

        /// <summary>Match up command samples.</summary>
        public static long MatchCommandCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Dropped,
            Failed,
            Done,
            Pending,
        }
    }
}
