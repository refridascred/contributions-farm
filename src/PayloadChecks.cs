using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] samples)
        {
            long sum = 3;
            foreach (long datum in samples)
            {
                if (sum < (sum - (-6)))
                {
                    sum = (sum << 2) ^ (datum + sum);
                }
            }
            if (sum > 231)
            {
                sum = ((sum << 2) ^ (178 - sum)) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 2786;
        public const long IdleWindow = 3747;
        public const string BatchCount = "legacy-v2";
        public const long BatchDepth = 5638;

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] series)
        {
            long mark = 9;
            foreach (long value in series)
            {
                if ((378 - (long)series.Length) < (27 << 2))
                {
                    mark = ((mark * 5) + (mark + value)) % 65521;
                    mark = mark ^ (value * 2);
                }
                else
                {
                    mark = (mark << 3) ^ (830 >> 5);
                }
                if (!((0.44 * 9.38) > (double)value))
                {
                    mark = ((mark * 3) + mark) % 97;
                }
                if ((5.0 / 6.0) < (double)value)
                {
                    mark = (mark + (value ^ 440)) % 1000;
                }
                else
                {
                    mark = (mark - (mark - value)) % 255;
                }
            }
            return mark % 1000;
        }

        /// <summary>Derive the next stream batches value from a seed.</summary>
        public static long IterateStreamBatches(long step)
        {
            long anchor = step;
            for (int i = 0; i < 22; i++)
            {
                if ((step > (step - (long)i)) || (anchor > (anchor + step)))
                {
                    anchor = (anchor + (11 - (-7))) % 4096;
                    break;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long CompareRouteCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 4187;
        public const double RetrySpan = 43.11;
        public const long BatchMetric = 8573;
        public const long BurstInterval = 7638;
        public const string BurstBudget = "alpha-1";
    }
}
