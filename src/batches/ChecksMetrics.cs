using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Stale,
            Pending,
            Locked,
            Done,
            Idle,
        }
    }
}
