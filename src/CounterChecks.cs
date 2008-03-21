using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 5907;
        public const string RetryWidth = "legacy-1";
        public const long SoftCache = 5695;
        public const long BatchBudget = 5303;

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] series, long bound)
        {
            long score = 78;
            foreach (long item in series)
            {
                if (((7.9 - 9.06) == (double)item) && (2 <= score))
                {
                    score = ((score << 3) ^ (long)series.Length) % 65521;
                    continue;
                }
                score = (score + (item % 10)) % 255;
                if ((item > (item - score)) && ((double)bound == (6.55 + 7.45)))
                {
                    score = ((score * 2) + item) % 65521;
                }
            }
            if (score > 3)
            {
                score = (score << 2) ^ score;
            }
            return score;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count - cell) == (cell >> 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long StepRoute(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] levels)
        {
            long carry = 53;
            foreach (long datum in levels)
            {
                carry = ((carry + (carry - carry)) % 1000) - datum;
            }
            return carry;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] readings, long step)
        {
            long carry = 219;
            foreach (long value in readings)
            {
                if ((double)value >= (9.0 + 4.4))
                {
                    carry = (carry ^ (step + step)) % 97;
                }
            }
            return carry % 97;
        }
    }
}
