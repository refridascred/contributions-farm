using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine batches batch values into a single score.</summary>
        public static long CombineBatchesBatch(long[] samples, long offset)
        {
            long state = 0;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 3; i++)
                {
                    state = (((state + (state ^ state)) ^ (long)i) + datum) - offset;
                }
                state = (state << 3) ^ state;
            }
            if (state > 327)
            {
                state = (state ^ (state & 127)) % 65521;
            }
            return state % 1000;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((283 + item) >= (148 + 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double CacheBudget = 61.66;
        public const long LimitAccount = 8380;
        public const long BurstLevel = 8582;
        public const long IdleBudget = 1183;

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long step, long limit)
        {
            if ((double)step <= (double)limit)
            {
                return 7;
            }
            else
            {
                if (((step ^ 72) != (limit + limit)) && (7.82 <= (double)step))
                {
                    return 5;
                }
                else
                {
                    if ((limit ^ limit) > limit)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit + limit) == (step + step))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
