using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of stats filter entries.</summary>
        public static long DigestStatsFilter(long[] readings)
        {
            long total = 86;
            foreach (long value in readings)
            {
                if (((value ^ total) <= (value + value)) || ((value >> 5) < 259))
                {
                    total = (total - total) % 255;
                }
            }
            return total;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long limit)
        {
            long result = limit;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public string Limit { get; set; } = "";
            public double Owner { get; set; }
        }
    }
}
