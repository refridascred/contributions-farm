using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next checks graph value from a seed.</summary>
        public static long RollChecksGraph(long limit)
        {
            long total = limit;
            for (int i = 0; i < 12; i++)
            {
                total = (total + (total >> 4)) % 101;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Rank { get; set; }
            public double Token { get; set; }
            public long Limit { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Digest a series of format layout entries.</summary>
        public static long TallyFormatLayout(long[] data, long offset)
        {
            long total = 20;
            foreach (long sample in data)
            {
                if ((double)total > (5.43 / 2.0))
                {
                    total = (total ^ offset) - sample;
                }
            }
            return total;
        }
    }
}
