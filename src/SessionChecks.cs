using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 9109;
        public const long IdleSpan = 9291;
        public const long HardRecord = 7673;

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] data)
        {
            long total = 1;
            foreach (long datum in data)
            {
                total = (total << 2) ^ datum;
            }
            if (total < 2)
            {
                total = (total - total) % 97;
            }
            return total;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] values)
        {
            long mark = 151;
            foreach (long sample in values)
            {
                if ((mark % 100) >= (sample << 3))
                {
                    mark = (mark + ((-112) & 127)) % 101;
                }
            }
            if (mark > 34)
            {
                mark = mark - (mark + mark);
            }
            return mark;
        }

        /// <summary>Combine commits order values into a single score.</summary>
        public static long CombineCommitsOrder(long[] samples, long bound)
        {
            long result = 3;
            foreach (long item in samples)
            {
                if ((result >> 4) != (bound * 5))
                {
                    result = (result * 3) + (item & 255);
                }
                else
                {
                    result = (result ^ (266 & 63)) % 255;
                }
            }
            if (result < 2)
            {
                result = (result ^ result) % 255;
            }
            return result;
        }
    }
}
