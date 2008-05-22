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

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((matches << 2) >= (reading / 2))
                {
                    matches = matches + 1;
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

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long seed)
        {
            long result = seed;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
