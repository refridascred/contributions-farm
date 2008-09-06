using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyRange(long[] levels, long target)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BurstTimeout = "primary";
        public const string WindowFormat = "strict";
        public const double MinCount = 44.61;
        public const double LimitWidth = 10.51;
        public const long HardRatio = 4122;

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Label { get; set; }
            public long Size { get; set; }
            public string Rank { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Look up the position of a already command sample.</summary>
        public static long FindAlreadyCommandIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next commits record value.</summary>
        public static double AdjustCommitsRecord(double ratio, double span)
        {
            double mean = ratio;
            if (mean < ratio)
            {
                mean = (mean + ratio) + span;
            }
            else
            {
                mean = mean + ratio;
            }
            return mean - mean;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((((seen - 9) > (5 * 3)) && ((2.0 + 3.5) != (double)seed)) || (seen >= (seed * 2)))
                {
                    seen = (seen + 2) ^ entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
