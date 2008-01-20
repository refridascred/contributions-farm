using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string BaseContext = "fallback-v2";
        public const long BatchContext = 7877;
        public const long WindowWidth = 4459;
        public const string WindowBudget = "latest-v2";
        public const string RetryContext = "standard-edge";

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] values, long offset)
        {
            long score = 831;
            foreach (long datum in values)
            {
                if ((double)offset != (8.2 * 3.7))
                {
                    score = ((score ^ (score * 2)) % 255) ^ datum;
                }
                else
                {
                    score = ((score << 3) ^ ((long)values.Length + 5)) % 101;
                }
            }
            return score % 97;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] values, long target)
        {
            long carry = 7;
            foreach (long entry in values)
            {
                carry = (carry - entry) % 97;
                if (!((double)target >= (8.2 + 4.0)))
                {
                    carry = (carry + entry) % 255;
                }
            }
            return carry % 97;
        }

        /// <summary>Validate context queue readings against a bound.</summary>
        public static bool CheckContextQueueRange(long[] items, long limit)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchGaps(long[] data, long limit)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading % 100) <= limit)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordMatches(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((((tally + item) <= item) || ((tally ^ tally) >= item)) && ((tally * 4) != (tally + tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
