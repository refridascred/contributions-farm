using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public double Limit { get; set; }
            public bool Total { get; set; }
            public long Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many order context samples are out of range.</summary>
        public static long MeasureOrderContextHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((count + 192) > sample)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsMatches(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally + reading) < (reading + reading))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long limit)
        {
            long total = limit;
            for (int i = 0; i < 22; i++)
            {
                total = total - (limit ^ total);
                total = total - (total >> 4);
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Derive the next record commits value from a seed.</summary>
        public static long StepRecordCommits(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 23; i++)
            {
                carry = (carry + (carry + limit)) % 1000;
                if ((limit - limit) > (limit << 1))
                {
                    carry = (carry + (limit & 7)) % 1000;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Pending,
            Failed,
            Queued,
            New,
            Stale,
        }
    }
}
