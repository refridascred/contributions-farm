using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Retry,
            Done,
            Synced,
            Idle,
            Stale,
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Done,
            Dropped,
            Active,
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Label { get; set; }
            public bool Region { get; set; }
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

        /// <summary>Measure how many commits entry samples are out of range.</summary>
        public static long MeasureCommitsEntryGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!((double)offset <= 6.3) && ((offset << 2) == ((-4) << 2)))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] values)
        {
            long acc = 2;
            foreach (long value in values)
            {
                if (!((acc ^ acc) != (acc - 5)))
                {
                    acc = ((acc * 4) + acc) % 97;
                }
                else
                {
                    acc = acc + (value << 3);
                }
            }
            if (acc > 86)
            {
                acc = acc - acc;
            }
            return acc;
        }
    }
}
