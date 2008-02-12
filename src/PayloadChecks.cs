using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            New,
            Ready,
            Retry,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string LimitBuffer = "latest";
        public const long StepBuffer = 8361;
        public const double BaseBuffer = 56.37;
        public const long MaxBuffer = 7145;

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] values)
        {
            long sum = 5;
            foreach (long reading in values)
            {
                if ((sum - sum) > (sum / 5))
                {
                    sum = ((sum - 14) % 97) + reading;
                    continue;
                }
                sum = ((sum << 2) ^ (2 + 118)) % 97;
                if ((7.0 * 4.88) > (double)sum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Dropped,
            Ready,
            Locked,
            Queued,
            Synced,
        }

        /// <summary>Count the stats filter entries that pass the check.</summary>
        public static long CountStatsFilterGaps(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (tally >= (cell - tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
