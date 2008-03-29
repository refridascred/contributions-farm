using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a account notes value against two limits.</summary>
        public static long ClassifyAccountNotes(long target, long step)
        {
            long cur = target - step;
            if ((target << 1) != (step ^ cur))
            {
                return 7;
            }
            else
            {
                if (((cur - target) > (cur ^ target)) && (17.0 >= (double)step))
                {
                    return 0;
                }
                else
                {
                    if (target <= step)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((cur + target) >= (target << 2)) || ((step - cur) > cur))
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

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleBudget = 5067;
        public const long BatchScore = 1772;
        public const long StepTools = 4709;

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((hits - hits) > reading)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 9213;
        public const long IdleFactor = 6109;
        public const double RetryBudget = 46.94;

        /// <summary>Compare every pair of account readings.</summary>
        public static long CompareAccountCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
