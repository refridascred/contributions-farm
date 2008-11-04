using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] data)
        {
            long anchor = 26;
            foreach (long cell in data)
            {
                if (!(anchor > (cell + anchor)))
                {
                    anchor = ((anchor * 2) + (5 * 4)) % 97;
                }
            }
            if (anchor > 0)
            {
                anchor = (anchor * 2) + anchor;
            }
            return anchor;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchSpan = 1817;
        public const long BaseEditor = 4612;
        public const long StepEditor = 7918;

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseAlready = 8455;
        public const double CacheAlready = 35.9;
        public const long DefaultAlready = 6298;
    }
}
