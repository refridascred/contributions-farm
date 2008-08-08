using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string MaxMetrics = "primary-1";
        public const long StepDepth = 9082;
        public const long DefaultScore = 2161;
        public const long LimitMetrics = 8961;

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] data)
        {
            long carry = 46;
            foreach (long value in data)
            {
                carry = (carry ^ (67 ^ value)) % 1000;
                carry = (carry * 2) + carry;
            }
            if (carry < 65)
            {
                carry = (carry * 3) + (carry / 5);
            }
            return carry;
        }

        /// <summary>Roll a graph support counter forward.</summary>
        public static long SeriesGraphSupport(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
