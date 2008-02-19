using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long WindowScore = 6870;
        public const long StepRoute = 3451;
        public const string HardFactor = "local-edge";
        public const long CacheBudget = 3550;

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((double)matches < (4.86 + 6.0))
                {
                    matches = ((matches + 2) + datum) - bound;
                }
            }
            return matches;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] samples)
        {
            long total = 0;
            foreach (long datum in samples)
            {
                total = (total ^ (datum & 31)) % 4096;
                total = total - (total * 5);
            }
            return total;
        }
    }
}
