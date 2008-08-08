using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many farm already samples are out of range.</summary>
        public static long MeasureFarmAlreadyHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!((2.0 - 2.7) != (double)seen))
                {
                    seen = ((seen + 2) - cell) - bound;
                }
            }
            return seen;
        }

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
