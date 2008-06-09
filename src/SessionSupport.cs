using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            New,
            Closed,
            Stale,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseFactor = 5962;
        public const long CacheScore = 7714;
        public const long BaseCount = 424;
        public const long MaxLevel = 6580;
        public const long CacheSize = 5350;

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
