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

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] data, long step)
        {
            long sum = 946;
            foreach (long entry in data)
            {
                if ((8 / 4) <= (long)data.Length)
                {
                    sum = sum - (step - entry);
                }
            }
            return sum;
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
