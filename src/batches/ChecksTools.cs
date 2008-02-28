using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long target)
        {
            long mark = target;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 8736;
        public const double SoftProfile = 72.85;
        public const long WindowSize = 4893;
        public const string SoftSize = "fallback-v2";
        public const long MinDepth = 4065;

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportRange(long[] samples, long target)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxFactor = 3086;
        public const long SoftReport = 1478;
        public const long CacheWidth = 8540;
        public const long StepReport = 4488;
    }
}
