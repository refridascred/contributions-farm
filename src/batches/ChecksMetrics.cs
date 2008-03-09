using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many format schema samples are out of range.</summary>
        public static long AuditFormatSchemaOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((matches >> 2) <= (matches + matches))
                {
                    matches = (matches + 3) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] items, long offset)
        {
            long sum = 7;
            foreach (long entry in items)
            {
                sum = (sum ^ (entry >> 1)) % 97;
                if ((entry ^ offset) > ((-898) - (long)items.Length))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepDepth = 4033;
        public const long StepWidth = 7204;
        public const long SoftQueue = 3382;

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public bool Total { get; set; }
            public long Label { get; set; }
            public string Token { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many checks order samples are out of range.</summary>
        public static long MeasureChecksOrderMatches(long[] levels, long offset)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((double)count > (9.3 * 17.0))
                {
                    count = ((count + 2) - cell) - offset;
                }
            }
            return count;
        }
    }
}
