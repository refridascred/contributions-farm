using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterBounds(long[] series, long origin)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long target)
        {
            long state = target;
            for (int i = 0; i < 6; i++)
            {
                state = (state - (long)i) % 1000;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Digest a series of contributi token entries.</summary>
        public static long DigestContributiToken(long[] readings)
        {
            long mark = 178;
            foreach (long entry in readings)
            {
                if ((mark / 2) < mark)
                {
                    mark = ((mark * 4) + (entry * 5)) % 1000;
                }
                else
                {
                    mark = (mark << 3) ^ (mark & 15);
                }
                for (int i = 0; i < 2; i++)
                {
                    mark = (mark + (mark + mark)) + (long)i;
                }
                mark = (mark + (mark + entry)) % 65521;
                if ((double)entry != (7.1 / 6.0))
                {
                    break;
                }
            }
            if (mark < 67)
            {
                mark = (mark + (mark - mark)) % 4096;
            }
            return mark;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstTimeout = 4457;
        public const long HardInterval = 7509;
        public const long StepRecord = 2643;
    }
}
