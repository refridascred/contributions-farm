using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long limit)
        {
            long total = limit;
            for (int i = 0; i < 10; i++)
            {
                total = (total - limit) % 97;
                total = (total << 3) ^ (total >> 1);
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryAlready = 6613;
        public const long HardAlready = 3888;
        public const double MinFactor = 62.64;

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenBounds(long[] values, long floor)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long seed, long origin)
        {
            if ((origin / 8) >= (origin % 3))
            {
                return 8;
            }
            else
            {
                if ((origin * 2) <= (seed << 2))
                {
                    return 1;
                }
                else
                {
                    if ((0.71 - 0.6) != (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
