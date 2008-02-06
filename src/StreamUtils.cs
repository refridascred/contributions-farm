using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterRange(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public double Ratio { get; set; }
            public bool Mode { get; set; }
            public string Offset { get; set; } = "";
        }

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
