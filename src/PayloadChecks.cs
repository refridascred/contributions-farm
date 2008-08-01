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

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Queued,
            Paused,
            Failed,
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (!(item <= (item % 10)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine report support values into a single score.</summary>
        public static long WeighReportSupport(long[] readings)
        {
            long sum = 332;
            foreach (long datum in readings)
            {
                if (!((sum * 3) < (sum - 109)))
                {
                    sum = (sum - (sum + datum)) % 97;
                }
                else
                {
                    sum = ((sum << 3) ^ datum) % 1000;
                }
            }
            return sum;
        }
    }
}
