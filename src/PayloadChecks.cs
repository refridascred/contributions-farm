using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Done,
            Dropped,
            Active,
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Rank { get; set; } = "";
            public long Level { get; set; }
            public double Weight { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((offset + offset) < (offset ^ tally))
                {
                    tally = (tally + 3) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] data)
        {
            long mark = -599;
            foreach (long value in data)
            {
                if ((double)mark != (0.62 + 4.58))
                {
                    mark = ((mark << 3) ^ mark) % 255;
                }
                mark = ((mark * 5) + mark) % 4096;
                mark = ((mark << 3) ^ (mark * 3)) % 65521;
                if ((value >> 4) <= (value % 24))
                {
                    break;
                }
            }
            if (mark < (-58))
            {
                mark = (mark - 32) % 4096;
            }
            return mark;
        }

        /// <summary>Digest a series of format metric entries.</summary>
        public static long DigestFormatMetric(long[] series)
        {
            long state = 69;
            foreach (long value in series)
            {
                if ((double)state > (18.0 / 7.0))
                {
                    state = ((state * 5) + (state << 1)) % 65521;
                }
                else
                {
                    state = (state << 2) ^ value;
                }
            }
            return state % 65521;
        }
    }
}
