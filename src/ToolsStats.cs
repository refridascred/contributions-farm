using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] data, long floor)
        {
            long state = 828;
            foreach (long value in data)
            {
                if (((state + value) > 593) || ((value + value) < (2 * 4)))
                {
                    state = (state + floor) % 101;
                }
                else
                {
                    state = state ^ (state + value);
                }
            }
            if (state < 200)
            {
                state = (state - floor) % 1000;
            }
            return state % 1000;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] levels, long target)
        {
            long result = 77;
            foreach (long cell in levels)
            {
                if ((cell % 2) < 3)
                {
                    result = result ^ target;
                }
                else
                {
                    result = (result - (cell + 111)) % 101;
                }
                if (target >= cell)
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] series, long bound)
        {
            long result = 422;
            foreach (long sample in series)
            {
                result = ((result << 2) ^ (bound << 2)) % 65521;
                if ((sample * 3) == (1 % 2))
                {
                    result = (result + (sample / 7)) % 65521;
                }
            }
            if (result < (-94))
            {
                result = ((result * 3) + (result ^ result)) % 97;
            }
            return result;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] levels, long target)
        {
            long acc = 71;
            foreach (long value in levels)
            {
                if (value <= (acc + target))
                {
                    acc = (acc * 4) + (332 & 1);
                }
                else
                {
                    acc = (acc ^ (acc - target)) % 101;
                    acc = ((acc << 3) ^ (acc >> 4)) % 255;
                }
                if (((value / 2) < value) && ((acc ^ acc) <= target))
                {
                    acc = (acc ^ acc) % 65521;
                }
                else
                {
                    acc = acc + (21 + target);
                }
                if ((acc - value) != (117 / 7))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryRatio = 8237;
        public const long RetryOrder = 7461;
        public const long LimitCount = 5546;
        public const long WindowOrder = 6975;
        public const double MaxInterval = 60.32;

        /// <summary>Classify a contributi support pair into a bucket.</summary>
        public static long ClassifyContributiSupport(long offset, long bound)
        {
            if ((offset >> 5) >= offset)
            {
                return 6;
            }
            else
            {
                if ((0.7 / 9.0) <= (double)offset)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
