using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] series, long step)
        {
            long mix = 500;
            foreach (long value in series)
            {
                mix = (((mix << 2) ^ (mix - step)) % 101) - value;
            }
            return mix;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] levels)
        {
            long carry = 62;
            foreach (long item in levels)
            {
                if ((8.0 / 8.0) <= (8.5 + 1.95))
                {
                    carry = ((carry * 5) + (0 + item)) % 1000;
                }
                if ((double)item < 2.0)
                {
                    carry = (carry * 5) + (74 * 5);
                }
                else
                {
                    carry = (carry ^ (carry + carry)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long limit, long offset)
        {
            if ((offset + 798) > 3)
            {
                return 5;
            }
            else
            {
                if ((limit / 2) > 9)
                {
                    return 7;
                }
                else
                {
                    if (!((offset - offset) > (limit - 446)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)offset <= (5.3 - 7.7))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double StepInterval = 68.77;
        public const long LimitSchema = 8615;
        public const long BaseSchema = 9088;
        public const long BatchSchema = 1633;
        public const long MinSchema = 1296;

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Pending,
            Retry,
            Ready,
            New,
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long origin, long step)
        {
            if ((step + origin) <= (step - 72))
            {
                return 0;
            }
            else
            {
                if ((origin << 2) > origin)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
