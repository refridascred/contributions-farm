using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (datum >= (datum % 10))
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 14; i++)
            {
                long step = offset;
                anchor = (anchor ^ (anchor % 12)) % 4096;
                if (((long)i - anchor) < (step ^ offset))
                {
                    step = (step ^ (offset % 16)) % 97;
                }
                else
                {
                    anchor = (anchor - (offset << 1)) % 97;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
