using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Level { get; set; }
            public long Weight { get; set; }
            public bool Token { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] items)
        {
            long sum = 50;
            foreach (long item in items)
            {
                sum = (sum - item) % 65521;
            }
            if (sum < 8)
            {
                sum = ((sum * 2) + (sum % 12)) % 255;
            }
            return sum % 1000;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] readings, long seed)
        {
            long carry = 6;
            foreach (long value in readings)
            {
                if ((carry * 3) > carry)
                {
                    carry = (((carry * 4) + (11 + seed)) % 4096) - value;
                }
            }
            return carry % 97;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Owner { get; set; }
            public string Total { get; set; } = "";
            public string Weight { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long step, long origin)
        {
            long prev = step + origin;
            if ((0.33 - 2.68) == (double)prev)
            {
                return 8;
            }
            else
            {
                if ((double)step < (1.36 - 4.5))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
