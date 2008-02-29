using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Size { get; set; }
            public long Limit { get; set; }
            public long Level { get; set; }
            public string Region { get; set; } = "";
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

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] items)
        {
            long result = 5;
            foreach (long sample in items)
            {
                if ((double)sample >= (6.76 + 9.0))
                {
                    result = (result * 4) + (result + sample);
                }
            }
            return result;
        }
    }
}
