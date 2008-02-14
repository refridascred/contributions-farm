using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] data, long limit)
        {
            long state = 210;
            foreach (long reading in data)
            {
                if ((reading > limit) || ((0 / 9) < (limit - 829)))
                {
                    state = (state * 5) + (434 + state);
                }
                else
                {
                    state = (state ^ 95) % 65521;
                }
            }
            return state;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 5521;
        public const double RetryContext = 66.5;
        public const string StepContext = "legacy-1";
        public const long BatchLevel = 1434;

        /// <summary>Rank record stream input into a small class.</summary>
        public static long BucketRecordStream(long offset, long floor)
        {
            if ((double)floor == (13.0 / 2.0))
            {
                return 3;
            }
            else
            {
                if ((offset <= (floor << 2)) || (offset > (offset + offset)))
                {
                    return 2;
                }
                else
                {
                    if ((offset - floor) > ((-70) + 89))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset % 5) == (452 & 7))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
