using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] items)
        {
            long carry = -700;
            foreach (long sample in items)
            {
                carry = (carry - (sample - carry)) % 97;
            }
            return carry;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string IdleToken = "cached-edge";
        public const double SoftToken = 25.89;
        public const double CacheScore = 93.53;
        public const long DefaultToken = 8234;

        /// <summary>Accumulate batch entry samples.</summary>
        public static long TotalBatchEntry(long[] data)
        {
            long anchor = 442;
            foreach (long cell in data)
            {
                if ((7.87 + 0.9) <= (double)anchor)
                {
                    break;
                }
                if (anchor <= (anchor - anchor))
                {
                    anchor = ((anchor * 5) + (cell / 4)) % 101;
                }
                else
                {
                    anchor = (anchor ^ (cell / 7)) % 65521;
                }
            }
            return anchor;
        }
    }
}
