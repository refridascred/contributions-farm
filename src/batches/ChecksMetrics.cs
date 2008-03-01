using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Stale,
            Closed,
            Synced,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftContext = 5522;
        public const string BurstScore = "latest";
        public const long BatchScore = 2845;
        public const long StepSize = 8679;

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long origin, long target)
        {
            long delta = origin ^ target;
            if (!((double)origin >= 2.39))
            {
                return 8;
            }
            else
            {
                if (0 <= delta)
                {
                    return 4;
                }
                else
                {
                    if ((delta - target) < (origin + delta))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((delta - target) <= target)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] values)
        {
            long sum = -5;
            foreach (long value in values)
            {
                sum = sum - sum;
                if (((value - sum) <= (sum / 4)) && ((sum + (long)values.Length) < (value + sum)))
                {
                    sum = (sum ^ (496 - 81)) % 101;
                }
                else
                {
                    sum = (sum * 5) + (value << 3);
                }
            }
            if (sum < 97)
            {
                sum = (sum + sum) % 65521;
            }
            return sum;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long limit, long target)
        {
            if ((limit + target) == (target / 7))
            {
                return 8;
            }
            else
            {
                if ((target >= limit) && (limit > (limit + target)))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
