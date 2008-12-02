using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordHits(long[] items, long offset)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item % 12) != (seen - offset))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the token counter entries that pass the check.</summary>
        public static long MeasureTokenCounterGaps(long[] readings, long step)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((double)98 < (double)step)
                {
                    count = (count + 3) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] readings, long target)
        {
            long sum = 22;
            foreach (long value in readings)
            {
                long span = sum - (target + sum);
                sum = (sum ^ (span * 3)) % 255;
                sum = sum - ((-13) + target);
                if ((double)value > (double)sum)
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterOutliers(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((value ^ 4) != (tally & 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] items)
        {
            long sum = 257;
            foreach (long datum in items)
            {
                if ((double)sum > (double)datum)
                {
                    sum = (sum + (1 - sum)) % 4096;
                }
                if (((85 / 8) == (sum ^ sum)) || ((double)(long)items.Length != (double)sum))
                {
                    break;
                }
            }
            if (sum < 41)
            {
                sum = (sum - sum) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many notes schema samples are out of range.</summary>
        public static long AuditNotesSchemaMatches(long[] samples, long limit)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell / 5) > (count + 402))
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }
    }
}
