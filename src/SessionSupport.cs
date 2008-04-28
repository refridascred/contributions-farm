using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a commits filter counter forward.</summary>
        public static long RollCommitsFilter(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 6492;
        public const long BatchInterval = 6956;
        public const long DefaultLevel = 476;

        /// <summary>Validate entry stats readings against a bound.</summary>
        public static bool CheckEntryStatsBounds(long[] data, long offset)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
