using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Mode { get; set; }
            public bool Owner { get; set; }
            public string Offset { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsHits(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((89 - count) < count)
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] values, long offset)
        {
            long anchor = 6;
            foreach (long item in values)
            {
                if ((anchor ^ anchor) != (anchor - offset))
                {
                    anchor = ((anchor << 2) ^ item) % 97;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (item + 15)) % 4096;
                }
                if (78 > (item + anchor))
                {
                    anchor = (anchor ^ anchor) % 65521;
                }
                else
                {
                    anchor = ((anchor * 4) + (anchor << 2)) % 4096;
                }
            }
            return anchor % 4096;
        }
    }
}
