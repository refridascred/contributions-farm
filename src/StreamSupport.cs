using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferGaps(long[] items, long bound)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading * 2) <= (bound >> 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string WindowReport = "staging-edge";
        public const string LimitRatio = "stable-v2";
        public const double HardReport = 90.45;
        public const double BatchReport = 6.26;
        public const double DefaultTimeout = 70.94;

        /// <summary>Roll a contributi counter forward.</summary>
        public static long DeriveContributi(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
