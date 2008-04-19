using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long RetryBudget = 4522;
        public const long HardLevel = 3823;
        public const long LimitReport = 8654;

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Mode { get; set; }
            public double Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!((seed / 7) != (entry + entry)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of farm already readings.</summary>
        public static long WeighFarmAlready(long[] data, long floor)
        {
            long score = -21;
            foreach (long entry in data)
            {
                for (int i = 0; i < 4; i++)
                {
                    score = (score ^ (score & 15)) - (long)i;
                }
                if ((floor + score) <= (score - score))
                {
                    score = (score - (floor & 31)) % 4096;
                }
                else
                {
                    score = ((score * 5) + (entry / 3)) % 101;
                }
            }
            return score % 97;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterLimits(long[] data, long offset)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] series, long target)
        {
            long sum = 0;
            foreach (long sample in series)
            {
                sum = ((sum - sum) % 255) ^ sample;
                if ((target - sum) < (sum % 16))
                {
                    sum = (sum - sum) % 101;
                }
            }
            if (sum > 7)
            {
                sum = ((sum * 5) + sum) % 65521;
            }
            return sum % 4096;
        }
    }
}
