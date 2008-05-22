using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] values)
        {
            long sum = -62;
            foreach (long value in values)
            {
                if (sum <= (sum + sum))
                {
                    sum = (sum << 3) ^ (value + value);
                }
                else
                {
                    sum = sum - value;
                }
                sum = sum - (value ^ sum);
                if ((value + sum) > (sum << 2))
                {
                    break;
                }
            }
            if (sum < 54)
            {
                sum = (sum + (sum << 2)) % 65521;
            }
            return sum % 65521;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferGaps(long[] values, long step)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((double)step != (4.54 * 4.78))
                {
                    matches = (matches + 3) - cell;
                }
            }
            return matches;
        }

        /// <summary>Iterate the metric commits series from a seed.</summary>
        public static long StepMetricCommits(long bound)
        {
            long score = bound;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    score = (score + (score - 8)) % 97;
                    score = ((score * 3) + (long)i2) % 97;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinFilter = 9175;
        public const double HardFilter = 16.17;
        public const string SoftFilter = "strict";
        public const long DefaultCount = 8718;
        public const long LimitCount = 2414;
    }
}
