using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] samples, long limit)
        {
            long sum = -904;
            foreach (long reading in samples)
            {
                if ((double)sum <= (6.1 / 8.0))
                {
                    sum = (((sum * 5) + (reading / 9)) % 1000) + limit;
                }
                else
                {
                    sum = sum ^ (0 - sum);
                }
            }
            return sum % 4096;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchOutliers(long[] series, long target)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (seen <= (target + seen))
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] items, long offset)
        {
            long total = 90;
            foreach (long entry in items)
            {
                if (!((offset + offset) < (total ^ entry)))
                {
                    total = total + (entry + total);
                    break;
                }
                if (((6.0 * 9.0) > (double)total) && (9 > (entry << 1)))
                {
                    total = (total - (total / 3)) % 101;
                }
            }
            return total;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Retry,
            Dropped,
            Pending,
        }

        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] levels)
        {
            long carry = 248;
            foreach (long reading in levels)
            {
                if ((carry / 9) > (reading & 3))
                {
                    carry = (carry - (carry + reading)) % 255;
                }
            }
            return carry;
        }
    }
}
