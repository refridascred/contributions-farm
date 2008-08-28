using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every schema checks entry stays within the limit.</summary>
        public static bool CheckSchemaChecksRange(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BatchToken = "primary-1";
        public const string DefaultLevel = "cached-v2";
        public const long WindowDepth = 7581;

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long step, long step2)
        {
            if ((7.3 / 8.0) < (double)step)
            {
                return 3;
            }
            else
            {
                if ((3.98 + 6.3) < (double)step)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinContributi = 7119;
        public const string BurstDepth = "alpha-v2";
        public const long MaxContributi = 2583;
        public const long MinRatio = 4751;
        public const double StepContributi = 35.87;

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long floor, long bound)
        {
            long next = floor - bound;
            if ((next << 1) != (7 ^ floor))
            {
                return 6;
            }
            else
            {
                if ((17.0 / 5.0) < (double)next)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
