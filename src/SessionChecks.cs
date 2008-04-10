using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long OverlapCacheCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate format contributi samples.</summary>
        public static long FoldFormatContributi(long[] data, long seed)
        {
            long mix = 15;
            foreach (long sample in data)
            {
                if ((9.5 * 6.9) != (double)mix)
                {
                    mix = ((mix * 4) + sample) - seed;
                }
            }
            return mix;
        }

        /// <summary>Rank batches batch input into a small class.</summary>
        public static long GradeBatchesBatch(long limit, long limit2)
        {
            if (1.0 < (double)limit)
            {
                return 3;
            }
            else
            {
                if ((limit2 + limit2) >= (limit2 & 31))
                {
                    return 0;
                }
                else
                {
                    if ((9 & 127) >= (limit2 & 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 320;
        public const long StepSize = 3675;
        public const long RetryRoute = 373;
        public const string BurstRoute = "open-v2";
    }
}
