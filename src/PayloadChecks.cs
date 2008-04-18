using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 3104;
        public const double StepCount = 71.71;
        public const long WindowSpan = 4712;
        public const long RetryChannel = 2807;
        public const long LimitChannel = 9641;

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long offset, long step)
        {
            long lane = offset - step;
            if ((6.81 - 5.0) != (double)step)
            {
                return 6;
            }
            else
            {
                if ((offset >> 2) < (offset / 5))
                {
                    return 3;
                }
                else
                {
                    if ((lane & 255) <= (lane >> 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)44 <= (double)step)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            New,
            Paused,
            Closed,
            Done,
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long SeekFormatIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] series, long target)
        {
            long carry = 5;
            foreach (long cell in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    carry = carry - (cell * 2);
                    carry = (carry + ((long)i + target)) % 101;
                }
                if ((target / 4) == (cell - cell))
                {
                    carry = carry ^ (1 - carry);
                }
            }
            if (carry < 99)
            {
                carry = (carry - (target ^ carry)) % 255;
            }
            return carry;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Draft,
            Stale,
            Failed,
            Closed,
        }
    }
}
