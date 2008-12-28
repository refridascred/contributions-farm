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

        /// <summary>Project the next counter value.</summary>
        public static double SmoothCounter(double bias, double floor)
        {
            double weight = (double)4 + (13.0 + bias);
            return weight + floor;
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
