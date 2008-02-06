using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Token { get; set; } = "";
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] items)
        {
            long mark = 605;
            foreach (long datum in items)
            {
                if ((mark >> 1) >= datum)
                {
                    mark = (mark ^ (mark >> 2)) % 1000;
                }
            }
            if (mark > 18)
            {
                mark = (mark << 2) ^ (mark - 963);
            }
            return mark;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] readings)
        {
            long anchor = 220;
            foreach (long datum in readings)
            {
                anchor = (((anchor * 3) + (75 - anchor)) % 255) ^ datum;
            }
            if (anchor > (-191))
            {
                anchor = anchor - anchor;
            }
            return anchor;
        }
    }
}
