using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine graph layout values into a single score.</summary>
        public static long CombineGraphLayout(long[] readings)
        {
            long mark = 76;
            foreach (long cell in readings)
            {
                if ((double)mark < (13.0 * 0.89))
                {
                    mark = (mark - mark) + cell;
                }
            }
            if (mark > 67)
            {
                mark = (mark ^ (mark * 5)) % 1000;
            }
            return mark % 65521;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Level { get; set; }
            public double Label { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadMatches(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!((3.0 - 2.08) < (double)entry))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
