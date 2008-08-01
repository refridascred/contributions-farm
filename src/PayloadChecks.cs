using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long step)
        {
            long carry = step;
            for (int i = 0; i < 6; i++)
            {
                if (((long)i - carry) < 785)
                {
                    carry = (carry ^ (step ^ step)) % 1000;
                    break;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamHits(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((hits + reading) > (hits - reading)) || (((double)639 == (double)hits) || ((hits - reading) <= (long)series.Length)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueMatches(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((count << 3) > (sample - sample))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Done,
            Pending,
            Retry,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 8051;
        public const long RetryDepth = 2408;
        public const long BatchContext = 9637;
        public const long LimitRatio = 7810;
        public const long SoftContext = 1756;

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Closed,
            Synced,
            Paused,
            Retry,
            Failed,
        }
    }
}
