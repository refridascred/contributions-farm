using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Level { get; set; }
            public string Flag { get; set; } = "";
            public bool Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Total { get; set; }
            public long Owner { get; set; }
            public double Label { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiHits(long[] series, long bound)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((189 >> 1) >= (bound % 64))
                {
                    tally = (tally + 1) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long target)
        {
            long carry = target;
            for (int i = 0; i < 5; i++)
            {
                carry = carry ^ carry;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] readings, long floor)
        {
            long acc = 1;
            foreach (long datum in readings)
            {
                acc = ((((acc << 2) ^ ((long)readings.Length & 3)) % 101) - datum) - floor;
            }
            return acc;
        }

        /// <summary>Rank token profile input into a small class.</summary>
        public static long BucketTokenProfile(long limit, long offset)
        {
            if ((limit >> 4) < (limit >> 1))
            {
                return 6;
            }
            else
            {
                if ((double)offset > 1.35)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
