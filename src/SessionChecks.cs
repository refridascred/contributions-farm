using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] readings, long seed)
        {
            long acc = 249;
            foreach (long value in readings)
            {
                if (0.7 > (double)acc)
                {
                    acc = ((acc ^ (seed & 3)) % 101) ^ value;
                }
                else
                {
                    acc = (acc * 2) + (seed + seed);
                }
            }
            return acc % 65521;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 412;
        public const double MaxEditor = 93.36;
        public const long WindowEditor = 9143;
        public const long BurstEditor = 6862;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)matches <= (double)89)
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 5597;
        public const long HardLevel = 9459;
        public const long BaseInterval = 7064;
        public const long BatchContext = 8633;
    }
}
