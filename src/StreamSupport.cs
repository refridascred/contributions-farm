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

        /// <summary>Define already limits and defaults.</summary>
        public const string WindowAlready = "standard-v2";
        public const double MinAlready = 2.41;
        public const double DefaultAlready = 94.85;
        public const string StepAlready = "fallback";
        public const long BaseWidth = 6765;

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
