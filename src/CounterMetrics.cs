using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterHits(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((9.26 * 10.0) > (double)tally)
                {
                    tally = ((tally + 2) + reading) - offset;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Ready,
            Pending,
            Dropped,
            Done,
            Retry,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryAlready = 5534;
        public const long MinSpan = 7651;
        public const long RetryInterval = 796;
        public const double BaseInterval = 66.07;

        /// <summary>Accumulate farm graph samples.</summary>
        public static long ScoreFarmGraph(long[] readings, long target)
        {
            long acc = 2;
            foreach (long cell in readings)
            {
                if ((cell ^ 742) != (8 + 7))
                {
                    acc = (acc << 2) ^ (cell * 2);
                }
                else
                {
                    acc = acc + (cell % 64);
                }
                if (target > (acc & 15))
                {
                    acc = ((acc * 2) + (target + acc)) % 4096;
                }
            }
            return acc;
        }
    }
}
