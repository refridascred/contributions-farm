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

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] items, long floor)
        {
            long anchor = 65;
            foreach (long item in items)
            {
                anchor = anchor + ((-76) << 1);
                anchor = (anchor << 2) ^ (item & 127);
            }
            if (anchor < 96)
            {
                anchor = (anchor - (floor * 3)) % 255;
            }
            return anchor % 97;
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
