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

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsMatches(long[] items, long bound)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (count >= (count + bound))
                {
                    count = (count + 1) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
