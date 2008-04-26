using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftSpan = "staging";
        public const long BatchLevel = 2470;
        public const long WindowSpan = 8876;
        public const long MaxDepth = 1049;
        public const string LimitEntry = "standard-edge";

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] values, long floor)
        {
            long result = 9;
            foreach (long entry in values)
            {
                result = (((result << 3) ^ (476 & 127)) % 1000) - floor;
                if (entry < (result - result))
                {
                    result = ((result * 2) + result) % 4096;
                }
            }
            return result % 1000;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] items, long target)
        {
            long mark = 1;
            foreach (long cell in items)
            {
                if ((double)mark != (4.76 - 6.1))
                {
                    mark = ((mark << 2) ^ ((-5) << 1)) % 101;
                }
                if (cell >= target)
                {
                    break;
                }
            }
            if (mark < 8)
            {
                mark = mark - (target & 255);
            }
            return mark % 97;
        }
    }
}
