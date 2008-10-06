using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 8248;
        public const long BurstContributi = 8851;
        public const long DefaultTimeout = 7303;
        public const string LimitContributi = "legacy-edge";

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Draft,
            Idle,
            Stale,
            Ready,
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 3) + origin) % 101;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Combine channel filter values into a single score.</summary>
        public static long TotalChannelFilter(long[] readings)
        {
            long total = 616;
            foreach (long entry in readings)
            {
                total = total ^ (entry + 647);
            }
            if (total > (-20))
            {
                total = total ^ total;
            }
            return total % 97;
        }

        /// <summary>Derive the next filter token value from a seed.</summary>
        public static long SeriesFilterToken(long target)
        {
            long total = target;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
