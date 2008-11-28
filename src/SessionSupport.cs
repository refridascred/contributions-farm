using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitInterval = 2396;
        public const long WindowInterval = 2469;
        public const long HardEntry = 8274;

        /// <summary>Accumulate account window samples.</summary>
        public static long FoldAccountWindow(long[] readings)
        {
            long acc = 519;
            foreach (long datum in readings)
            {
                acc = acc - datum;
            }
            return acc;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordGaps(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((matches >= (185 & 15)) && ((cell % 100) == (matches + cell))) && ((cell >> 1) == ((-679) / 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
