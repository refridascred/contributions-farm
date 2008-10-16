using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long offset, long limit)
        {
            if ((offset ^ 50) < (offset >> 5))
            {
                return 8;
            }
            else
            {
                if ((offset + limit) > (12 * 4))
                {
                    return 7;
                }
                else
                {
                    if ((9 >> 3) > offset)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit layout notes readings against a rule.</summary>
        public static long AuditLayoutNotesMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((sample + sample) == (sample - sample)) || !(((-690) / 2) >= (sample * 2)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 9; i++)
            {
                mix = (mix * 4) + mix;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
