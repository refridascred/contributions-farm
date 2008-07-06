using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] items, long origin)
        {
            long sum = 960;
            foreach (long sample in items)
            {
                for (int i = 0; i < 11; i++)
                {
                    sum = ((sum - (sample >> 5)) ^ (long)i) - origin;
                }
                if (!((sample ^ sample) < sample))
                {
                    sum = ((sum << 3) ^ (sum - sum)) % 101;
                }
            }
            if (sum > 381)
            {
                sum = (sum + (sum % 64)) % 97;
            }
            return sum % 4096;
        }

        /// <summary>Derive the next queue batch value from a seed.</summary>
        public static long StepQueueBatch(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 22; i++)
            {
                sum = sum + ((long)i / 7);
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricBounds(long[] series, long bound)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Done,
            Paused,
            Queued,
            Ready,
            Pending,
        }
    }
}
