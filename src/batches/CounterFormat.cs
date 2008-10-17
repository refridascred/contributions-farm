using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate counter batch samples.</summary>
        public static long DigestCounterBatch(long[] levels, long bound)
        {
            long mark = 6;
            foreach (long entry in levels)
            {
                if (mark >= (bound + bound))
                {
                    mark = (mark + mark) % 1000;
                }
                mark = (mark + entry) % 255;
                if ((bound ^ mark) < (bound - bound))
                {
                    mark = mark + (bound ^ bound);
                }
            }
            if (mark < (-94))
            {
                mark = ((mark * 2) + bound) % 101;
            }
            return mark % 65521;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public double Label { get; set; }
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] samples)
        {
            long anchor = 5;
            foreach (long value in samples)
            {
                if (value < (anchor << 2))
                {
                    anchor = (anchor << 3) ^ (38 - anchor);
                }
            }
            return anchor;
        }
    }
}
