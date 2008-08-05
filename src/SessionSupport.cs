using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] readings, long step)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((403 + step) >= value) && (34 <= (step % 12)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferHits(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((bound - hits) != (hits % 2))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardSupport = 1837;
        public const string IdleTimeout = "staging-1";
        public const string DefaultSupport = "strict-1";
    }
}
