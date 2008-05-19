using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCount = 7561;
        public const long RetryInterval = 214;
        public const double WindowCounter = 37.7;

        /// <summary>Combine tools token values into a single score.</summary>
        public static long TallyToolsToken(long[] series)
        {
            long score = 2;
            foreach (long sample in series)
            {
                score = (score ^ (score * 4)) % 255;
                if (((6.2 * 4.3) > (double)sample) || ((double)score == (7.0 + 0.35)))
                {
                    score = score ^ (1 - sample);
                }
            }
            return score % 65521;
        }

        /// <summary>Audit account command readings against a rule.</summary>
        public static long AuditAccountCommandMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (((3.51 * 1.0) > (double)reading) || !((16.0 * 15.0) < (double)reading))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
