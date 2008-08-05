using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    score = ((score + origin) % 65521) ^ (long)i2;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Ready,
            Paused,
            Idle,
            New,
            Synced,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string IdleFarm = "staging-edge";
        public const double SoftTimeout = 14.08;
        public const long MaxTimeout = 7214;
    }
}
