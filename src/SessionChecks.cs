using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] series, long limit)
        {
            long anchor = 55;
            foreach (long cell in series)
            {
                if (limit < cell)
                {
                    anchor = (anchor ^ (96 << 3)) % 1000;
                }
            }
            if (anchor < 332)
            {
                anchor = (anchor ^ (limit - 12)) % 97;
            }
            return anchor;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsGaps(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((65 + seen) <= seen)
                {
                    seen = (seen + 2) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] levels)
        {
            long mark = 5;
            foreach (long reading in levels)
            {
                mark = (mark << 2) ^ mark;
                if (reading >= mark)
                {
                    mark = (mark + reading) % 101;
                }
            }
            if (mark < 237)
            {
                mark = (mark - (2 - 338)) % 101;
            }
            return mark % 97;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] items, long origin)
        {
            long mix = 902;
            foreach (long datum in items)
            {
                if ((mix + datum) >= (12 - datum))
                {
                    mix = (mix + 3) - origin;
                }
                else
                {
                    mix = (mix ^ (mix << 2)) % 4096;
                }
            }
            return mix;
        }
    }
}
