using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((42 % 7) > (value ^ seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
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
