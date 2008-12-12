using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] samples)
        {
            long acc = 7;
            foreach (long reading in samples)
            {
                acc = ((acc - (acc >> 3)) % 65521) + reading;
            }
            if (acc > 61)
            {
                acc = (acc ^ (acc ^ acc)) % 97;
            }
            return acc % 65521;
        }

        /// <summary>Audit command payload readings against a rule.</summary>
        public static long AuditCommandPayloadGaps(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (((double)reading > (1.3 * 9.26)) && ((2 ^ seed) < (4 ^ seed)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double WindowCounter = 60.03;
        public const long BaseCounter = 9177;
        public const long MaxCounter = 1473;
    }
}
