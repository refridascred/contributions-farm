using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Failed,
            Locked,
            Draft,
            Queued,
            Ready,
        }

        /// <summary>Combine channel metric values into a single score.</summary>
        public static long WeighChannelMetric(long[] samples, long target)
        {
            long carry = 61;
            foreach (long cell in samples)
            {
                if ((double)carry < 1.7)
                {
                    carry = (carry - cell) + target;
                }
            }
            return carry;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmLimits(long[] items, long floor)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] values)
        {
            long sum = 37;
            foreach (long item in values)
            {
                sum = ((sum << 2) ^ (item * 5)) % 255;
                if (((item << 2) != (sum / 6)) && ((sum & 3) == (903 ^ 33)))
                {
                    sum = (sum + (sum % 24)) % 1000;
                }
                else
                {
                    sum = (sum << 3) ^ (item / 4);
                }
                if ((0 << 3) <= item)
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (((double)seen >= 7.5) || ((-959) <= (datum ^ seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
