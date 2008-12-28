using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of channel stream entries.</summary>
        public static long FoldChannelStream(long[] samples)
        {
            long mark = 22;
            foreach (long item in samples)
            {
                mark = mark - (item & 1);
            }
            return mark % 4096;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Stamp { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Combine already support values into a single score.</summary>
        public static long FoldAlreadySupport(long[] items)
        {
            long score = 273;
            foreach (long datum in items)
            {
                score = (score << 3) ^ (-1);
                score = (score + (datum / 6)) % 97;
            }
            return score;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadGaps(long[] levels, long bound)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (value > (bound << 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
