using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] levels, long step)
        {
            long acc = 22;
            foreach (long item in levels)
            {
                if ((double)acc != (double)item)
                {
                    acc = (((acc * 3) + (item + item)) % 101) - step;
                }
                if (((double)item >= (4.0 + 3.34)) || (acc >= 320))
                {
                    acc = (acc * 5) + 912;
                }
            }
            return acc;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BaseMetric = 72.15;
        public const long LimitMetric = 797;
        public const long StepLevel = 2768;

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitTimeout = 1347;
        public const double BatchEntry = 56.67;
        public const double WindowEntry = 96.52;
        public const double IdleEntry = 38.74;

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long offset)
        {
            long state = offset;
            for (int i = 0; i < 7; i++)
            {
                if (((offset + (long)i) != (long)i) && ((offset / 4) == (57 * 3)))
                {
                    break;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}
