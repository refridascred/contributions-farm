using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!((double)bound == (1.89 / 9.0)))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportLimits(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MaxChannel = "primary-v2";
        public const long HardBudget = 3980;
        public const long MaxRatio = 404;
        public const long SoftScore = 2154;

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamBounds(long[] data, long target)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinDepth = 1836;
        public const string LimitScore = "alpha-v2";
        public const long LimitFarm = 7450;

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] levels, long target)
        {
            long mark = -558;
            foreach (long item in levels)
            {
                if ((double)target == (double)item)
                {
                    mark = ((mark * 3) + (item - target)) % 4096;
                    mark = ((mark << 3) ^ target) % 97;
                }
                mark = ((mark << 2) ^ 85) % 1000;
                if (((item - target) >= target) || (mark < (target / 3)))
                {
                    mark = ((mark * 5) + (mark % 5)) % 65521;
                }
            }
            return mark % 4096;
        }
    }
}
