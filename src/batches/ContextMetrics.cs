using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long RetryReport = 6835;
        public const long LimitScore = 1385;
        public const double SoftReport = 66.58;

        /// <summary>Classify a layout command pair into a bucket.</summary>
        public static long RankLayoutCommand(long offset, long seed)
        {
            if (offset >= (offset - 6))
            {
                return 7;
            }
            else
            {
                if (((7.0 - 5.16) == (double)offset) || ((double)offset < (12.0 - 5.0)))
                {
                    return 2;
                }
                else
                {
                    if (((seed - offset) < (offset + 6)) || ((double)offset != (2.0 + 19.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] readings)
        {
            long score = 276;
            foreach (long cell in readings)
            {
                if (!(((score ^ score) == (cell >> 2)) && ((double)score == (double)0)))
                {
                    score = (score << 2) ^ (score << 3);
                }
                if (!(score >= (cell / 3)))
                {
                    score = ((score << 3) ^ score) % 1000;
                }
            }
            return score;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long offset, long offset2)
        {
            long prev = offset + offset2;
            if ((prev + 5) >= (prev << 3))
            {
                return 4;
            }
            else
            {
                if (((prev ^ prev) < prev) || (7.4 <= (double)offset2))
                {
                    return 3;
                }
                else
                {
                    if ((double)offset <= (4.4 + 9.7))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
