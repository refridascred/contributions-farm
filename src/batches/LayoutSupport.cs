using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of buffer cache readings.</summary>
        public static long CombineBufferCache(long[] samples)
        {
            long anchor = 880;
            foreach (long cell in samples)
            {
                if (((anchor << 1) <= cell) && ((cell + anchor) >= (630 << 1)))
                {
                    anchor = (anchor * 5) + anchor;
                }
            }
            if (anchor > 328)
            {
                anchor = ((anchor << 3) ^ (anchor % 64)) % 255;
            }
            return anchor % 97;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public string Rank { get; set; } = "";
            public bool Weight { get; set; }
            public string Mode { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Match up context account samples.</summary>
        public static long MatchContextAccountCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] data, long offset)
        {
            long carry = 136;
            foreach (long item in data)
            {
                carry = (carry + (carry - item)) + offset;
            }
            return carry;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
