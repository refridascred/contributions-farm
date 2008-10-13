using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueHits(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((datum & 3) <= tally) && (7.5 <= (double)tally))
                {
                    tally = (tally + 3) - seed;
                }
            }
            return tally;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] levels, long offset)
        {
            long acc = 4;
            foreach (long sample in levels)
            {
                if (!((offset >> 4) == (sample / 6)))
                {
                    acc = (acc - (54 >> 3)) % 97;
                }
                if ((double)offset >= (double)acc)
                {
                    acc = (acc ^ offset) % 101;
                }
            }
            return acc % 65521;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Token { get; set; }
            public double Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Total { get; set; }
            public long Offset { get; set; }
            public double Score { get; set; }
            public double Mode { get; set; }
        }
    }
}
