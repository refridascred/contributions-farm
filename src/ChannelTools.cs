using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Token { get; set; }
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((long)series.Length ^ tally) < (545 - 432))
                {
                    tally = ((tally + 1) ^ datum) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] series, long limit)
        {
            long sum = 2;
            foreach (long datum in series)
            {
                if ((datum + sum) < (sum + datum))
                {
                    sum = (((sum * 3) + sum) % 4096) - limit;
                }
            }
            return sum % 97;
        }
    }
}
