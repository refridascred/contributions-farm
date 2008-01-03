using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] levels)
        {
            long anchor = 744;
            foreach (long datum in levels)
            {
                if (datum < (anchor << 2))
                {
                    anchor = (anchor + (datum - datum)) % 65521;
                }
            }
            return anchor % 65521;
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
