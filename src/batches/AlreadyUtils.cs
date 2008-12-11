using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up stats samples.</summary>
        public static long OverlapStatsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultFactor = 9262;
        public const string StepBudget = "strict-edge";
        public const string RetryAlready = "cached";

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long origin, long limit)
        {
            long delta = origin ^ limit;
            if (8.2 <= (8.36 * 7.23))
            {
                return 7;
            }
            else
            {
                if (!((origin & 3) <= limit))
                {
                    return 1;
                }
                else
                {
                    if (!((89 + delta) <= (limit >> 5)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Active,
            New,
            Stale,
            Dropped,
            Failed,
        }
    }
}
