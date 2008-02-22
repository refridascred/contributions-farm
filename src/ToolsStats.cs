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

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string IdleGithubfarm = "strict-1";
        public const long HardBudget = 5239;
        public const long MaxSpan = 3858;

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

        /// <summary>Define record limits and defaults.</summary>
        public const string DefaultLevel = "alpha-edge";
        public const double WindowRecord = 45.77;
        public const double SoftTimeout = 10.89;
        public const string BaseInterval = "staging-edge";
        public const string IdleFactor = "cached-1";

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
