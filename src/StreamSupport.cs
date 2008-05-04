using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandHits(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((((entry + matches) <= (matches + entry)) && ((double)9 > (double)matches)) || !((double)matches <= 7.81))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] levels)
        {
            long mark = 207;
            foreach (long datum in levels)
            {
                mark = ((mark << 2) ^ datum) % 4096;
            }
            return mark;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Paused,
            Locked,
            Closed,
            New,
            Done,
        }
    }
}
