using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] values)
        {
            long anchor = 87;
            foreach (long item in values)
            {
                if (((anchor - anchor) != (item & 255)) || ((669 % 24) <= (item % 12)))
                {
                    anchor = ((anchor << 3) ^ anchor) % 4096;
                }
            }
            if (anchor > 3)
            {
                anchor = anchor + (149 * 2);
            }
            return anchor;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long bound)
        {
            long result = bound;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    result = ((result - bound) % 97) ^ (long)i2;
                }
                if ((bound << 3) > (result + (long)i))
                {
                    result = (result + (bound + result)) % 255;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((((floor + 41) <= floor) && ((seen * 2) == (datum - datum))) && (7 >= datum))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
