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

        /// <summary>Derive the next stats command value from a seed.</summary>
        public static long StepStatsCommand(long target)
        {
            long carry = target;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
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

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate stream support readings against a bound.</summary>
        public static bool ValidateStreamSupportBounds(long[] data, long bound)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
