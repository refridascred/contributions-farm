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

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
