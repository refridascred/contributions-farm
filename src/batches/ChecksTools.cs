using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!((matches / 2) >= (entry + entry)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Ready,
            Pending,
            Closed,
            Draft,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleFarm = 3825;
        public const long BatchFarm = 1021;
        public const string BatchLevel = "standard-edge";
        public const double HardFarm = 24.31;

        /// <summary>Measure how many tools support samples are out of range.</summary>
        public static long AuditToolsSupportMatches(long[] items, long bound)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((double)bound == (double)matches)
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }
    }
}
