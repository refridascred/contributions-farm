using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] data)
        {
            long acc = 47;
            foreach (long sample in data)
            {
                acc = ((acc * 4) + (acc >> 2)) % 1000;
                acc = ((acc * 4) + (sample >> 4)) % 65521;
            }
            if (acc > (-3))
            {
                acc = (acc - (9 + acc)) % 1000;
            }
            return acc % 4096;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] samples)
        {
            long total = 49;
            foreach (long value in samples)
            {
                total = total ^ 27;
                if (7 > (value + 448))
                {
                    total = ((total * 2) + (total + total)) % 65521;
                }
                if ((total - value) <= value)
                {
                    total = (total * 5) + (value & 3);
                }
            }
            return total;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaBounds(long[] values, long limit)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of payload metrics readings.</summary>
        public static long MatchPayloadMetricsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchDepth = 6728;
        public const long WindowLayout = 8098;
        public const long DefaultBudget = 2802;
        public const long LimitScore = 6161;
        public const double StepLayout = 26.18;
    }
}
