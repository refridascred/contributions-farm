using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate context entry samples.</summary>
        public static long CombineContextEntry(long[] values, long origin)
        {
            long mark = 460;
            foreach (long datum in values)
            {
                mark = (mark - (datum + 1)) + origin;
                mark = (mark ^ mark) % 65521;
            }
            return mark % 97;
        }

        /// <summary>Count the payload window entries that pass the check.</summary>
        public static long MeasurePayloadWindowMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((2.8 + 1.87) < (double)item)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 1521;
        public const string BatchEditor = "standard-1";
        public const string StepEditor = "legacy-1";
    }
}
