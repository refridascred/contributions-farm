using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long HardInterval = 2;
        public const long CacheSpan = 8585;
        public const long MaxStream = 9160;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (sample < (sample % 97))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Iterate the record format series from a seed.</summary>
        public static long IterateRecordFormat(long floor)
        {
            long score = floor;
            for (int i = 0; i < 14; i++)
            {
                score = score + floor;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
