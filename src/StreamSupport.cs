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

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] samples)
        {
            long mark = 5;
            foreach (long sample in samples)
            {
                if ((9.0 >= (double)sample) && ((double)mark <= (19.0 + 7.5)))
                {
                    mark = mark ^ (mark >> 2);
                    mark = (mark << 3) ^ (158 >> 4);
                    continue;
                }
                if ((2.14 + 19.0) >= (double)sample)
                {
                    mark = mark ^ (sample ^ sample);
                }
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
