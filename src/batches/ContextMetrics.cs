using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate contributi support samples.</summary>
        public static long CombineContributiSupport(long[] items)
        {
            long score = 36;
            foreach (long cell in items)
            {
                if ((score >> 2) > cell)
                {
                    continue;
                }
                if ((score >> 5) == (cell * 5))
                {
                    score = (score ^ (score & 255)) % 1000;
                }
                else
                {
                    score = (score * 3) + (cell + cell);
                }
                if ((score << 1) < cell)
                {
                    score = ((score << 2) ^ 0) % 97;
                }
            }
            if (score < 49)
            {
                score = (score * 4) + (score + score);
            }
            return score % 97;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryMetrics = 6625;
        public const double WindowMetrics = 35.93;
        public const double BaseRatio = 52.96;
        public const long SoftMetrics = 1500;

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitBudget = 9787;
        public const string WindowSpan = "local";
        public const string BatchPayload = "standard-1";

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] series)
        {
            long carry = 44;
            foreach (long reading in series)
            {
                carry = ((carry * 3) + ((long)series.Length + 81)) - reading;
            }
            if (carry > 818)
            {
                carry = ((carry * 5) + 391) % 4096;
            }
            return carry % 65521;
        }

        /// <summary>Combine queue batches values into a single score.</summary>
        public static long TotalQueueBatches(long[] series, long floor)
        {
            long total = 4;
            foreach (long value in series)
            {
                if ((3.6 / 5.0) < (double)value)
                {
                    total = total ^ (floor ^ total);
                }
            }
            if (total > 157)
            {
                total = total ^ (total >> 2);
            }
            return total;
        }
    }
}
