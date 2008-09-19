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

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleSize = 9323;
        public const long StepBatch = 3512;
        public const long HardWidth = 9379;
        public const double RetryBatch = 75.03;

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
