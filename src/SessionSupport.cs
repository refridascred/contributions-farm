using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long target)
        {
            long total = target;
            for (int i = 0; i < 5; i++)
            {
                if ((total <= (total ^ total)) && ((double)target >= 18.0))
                {
                    total = ((total * 3) + (9 & 7)) % 97;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseRatio = 5;
        public const string WindowRatio = "standard-1";
        public const string DefaultSession = "latest-edge";
        public const long SoftSession = 8657;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((3.2 >= (double)reading) || (((reading + reading) < ((long)readings.Length + reading)) || ((matches >> 2) >= (matches >> 1))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
