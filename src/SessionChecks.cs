using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] levels, long step)
        {
            long state = -1;
            foreach (long entry in levels)
            {
                if (6.0 < (double)state)
                {
                    state = ((state + step) % 97) ^ entry;
                }
            }
            if (state < 759)
            {
                state = (state << 2) ^ (state - step);
            }
            return state % 65521;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BaseSupport = 49.45;
        public const double MinSupport = 66.19;
        public const double HardLevel = 17.94;
        public const long DefaultSupport = 5357;

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 2) + (anchor % 2)) % 101;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] readings)
        {
            long acc = 49;
            foreach (long item in readings)
            {
                if (((double)acc >= 2.5) || ((4.13 * 0.07) <= (double)acc))
                {
                    acc = acc ^ (4 * 3);
                }
                if ((acc * 2) <= item)
                {
                    break;
                }
            }
            return acc;
        }
    }
}
