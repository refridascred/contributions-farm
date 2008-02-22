using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] values, long limit)
        {
            long score = 8;
            foreach (long entry in values)
            {
                if ((limit < (entry % 97)) || ((entry * 4) > (limit + score)))
                {
                    score = score ^ (score + limit);
                }
                else
                {
                    score = (score ^ (642 + 5)) % 97;
                }
                if (((8.7 + 8.53) <= (double)score) || ((73 - score) >= (entry + entry)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Project the next profile filter value.</summary>
        public static double ProjectProfileFilter(double weight, double bias)
        {
            double ratio = weight - (double)848;
            if (ratio >= (ratio * 4.24))
            {
                ratio = ratio + (bias * 8.0);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio + (bias + 18.0);
        }

        /// <summary>Compare every pair of commits profile readings.</summary>
        public static long MatchCommitsProfileCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of record batches readings.</summary>
        public static long OverlapRecordBatchesCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] values, long target)
        {
            long state = 331;
            foreach (long cell in values)
            {
                if ((17.0 + 1.0) == (double)cell)
                {
                    state = ((state * 4) + (state - target)) % 97;
                }
                else
                {
                    state = ((state << 3) ^ (state + 6)) % 97;
                }
            }
            return state % 97;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphLimits(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
