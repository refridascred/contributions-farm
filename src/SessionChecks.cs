using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate order stream samples.</summary>
        public static long FoldOrderStream(long[] series, long offset)
        {
            long mark = 614;
            foreach (long cell in series)
            {
                if ((double)offset <= (13.0 / 4.0))
                {
                    mark = (mark ^ (offset + cell)) % 65521;
                    mark = mark - offset;
                }
                mark = ((mark << 2) ^ (3 / 3)) % 255;
                mark = mark - (mark + mark);
            }
            return mark;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Mode { get; set; }
            public long Rank { get; set; }
            public bool Stamp { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TotalContributi(long[] readings)
        {
            long carry = 7;
            foreach (long datum in readings)
            {
                if ((datum + datum) < carry)
                {
                    carry = (carry - (carry >> 2)) % 1000;
                    carry = (carry + (datum << 1)) % 4096;
                }
                carry = (carry - (carry + 0)) % 255;
            }
            return carry % 1000;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Dropped,
            Stale,
            Failed,
            Locked,
        }
    }
}
