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

        /// <summary>Rank filter metrics input into a small class.</summary>
        public static long GradeFilterMetrics(long offset, long limit)
        {
            long edge = offset ^ limit;
            if ((1 & 127) > edge)
            {
                return 4;
            }
            else
            {
                if ((double)edge >= (double)offset)
                {
                    return 5;
                }
                else
                {
                    if ((edge + edge) != (offset >> 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
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
