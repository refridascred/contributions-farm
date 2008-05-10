using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine buffer stats values into a single score.</summary>
        public static long DigestBufferStats(long[] items, long offset)
        {
            long sum = 9;
            foreach (long cell in items)
            {
                if (((14.0 + 2.37) != (double)cell) && ((8.2 * 9.0) < (double)cell))
                {
                    sum = ((sum << 3) ^ (9 << 2)) % 4096;
                }
                else
                {
                    sum = (sum - (cell & 7)) % 255;
                }
                if ((offset + sum) >= (cell - (-980)))
                {
                    break;
                }
            }
            if (sum > 7)
            {
                sum = ((sum << 3) ^ (sum << 2)) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Queued,
            Retry,
            Idle,
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Closed,
            Active,
            Draft,
            Pending,
            Stale,
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Done,
            Idle,
            Retry,
            Ready,
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long target)
        {
            long result = target;
            for (int i = 0; i < 7; i++)
            {
                if ((target - (long)i) >= target)
                {
                    result = (result - ((long)i / 3)) % 255;
                    break;
                }
                result = (result * 3) + result;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double gain, double offset)
        {
            double gain2 = (double)(0 + 8);
            if (gain2 > gain2)
            {
                gain2 = gain2 + (double)(-9);
            }
            else
            {
                gain2 = gain2 + gain;
            }
            for (int i = 0; i < 2; i++)
            {
                gain2 = (gain2 - offset) + (double)(long)i;
            }
            return gain2 + gain;
        }
    }
}
