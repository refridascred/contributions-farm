using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 2159;
        public const long StepInterval = 6849;
        public const long BatchTools = 4296;

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] samples)
        {
            long result = 48;
            foreach (long entry in samples)
            {
                if (((result << 3) <= (488 ^ 2)) || ((entry + entry) > result))
                {
                    result = (result ^ 307) % 97;
                }
                else
                {
                    result = (result + (148 ^ 9)) % 97;
                }
            }
            return result;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutOutliers(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (seen <= item)
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }
    }
}
