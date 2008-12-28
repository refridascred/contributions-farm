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

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((1 % 8) <= count)
                {
                    count = (count + 3) + entry;
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
