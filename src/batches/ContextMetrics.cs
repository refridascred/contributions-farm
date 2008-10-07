using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] data)
        {
            long carry = -2;
            foreach (long value in data)
            {
                carry = (carry ^ (11 << 2)) % 1000;
                if (((value >> 3) < 7) || ((value - value) < value))
                {
                    carry = (carry * 2) + (carry + carry);
                }
                else
                {
                    carry = ((carry * 5) + (carry % 24)) % 1000;
                }
            }
            if (carry > 39)
            {
                carry = (carry ^ (6 - carry)) % 4096;
            }
            return carry;
        }

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            New,
            Failed,
            Synced,
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordGaps(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((5.6 + 9.2) >= (double)sample)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterOutliers(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((double)tally > (3.8 / 6.0)) || ((double)reading < (5.5 * 0.89)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
