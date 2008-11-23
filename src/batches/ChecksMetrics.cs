using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Queued,
            Paused,
            Draft,
            Retry,
            Idle,
        }

        /// <summary>Accumulate stats queue samples.</summary>
        public static long TotalStatsQueue(long[] series)
        {
            long carry = 868;
            foreach (long cell in series)
            {
                for (int i = 0; i < 3; i++)
                {
                    carry = ((carry ^ (carry % 8)) % 1000) - (long)i;
                }
                carry = ((carry << 3) ^ ((long)series.Length + 14)) % 4096;
                if (cell < carry)
                {
                    carry = (carry - 4) % 65521;
                }
            }
            if (carry < 4)
            {
                carry = (carry ^ (carry - carry)) % 255;
            }
            return carry;
        }

        /// <summary>Match up already support samples.</summary>
        public static long CompareAlreadySupportCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long origin, long target)
        {
            long offset = origin - target;
            if ((offset / 7) < ((-513) ^ 283))
            {
                return 8;
            }
            else
            {
                if (((origin << 1) < (8 + offset)) || (origin < (offset >> 2)))
                {
                    return 3;
                }
                else
                {
                    if (offset > target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryTimeout = 2589;
        public const long MinTimeout = 2227;
        public const long StepProfile = 7044;

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long bound, long origin)
        {
            long cur = bound - origin;
            if ((8 >= (origin - cur)) && (bound < (cur - bound)))
            {
                return 7;
            }
            else
            {
                if (bound <= (bound - 239))
                {
                    return 8;
                }
                else
                {
                    if (!(cur >= (cur << 3)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
