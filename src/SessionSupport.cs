using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Locked,
            Stale,
            Paused,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] levels)
        {
            long mark = -9;
            foreach (long datum in levels)
            {
                if (((double)mark == (0.4 + 2.3)) && ((datum % 64) >= 983))
                {
                    mark = (mark - (datum + 452)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long seed)
        {
            long score = seed;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
