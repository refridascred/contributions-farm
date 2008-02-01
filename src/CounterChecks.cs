using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long StepScore = 2317;
        public const double BatchSpan = 14.99;
        public const long BaseProfile = 1932;
        public const long DefaultTimeout = 7688;
        public const long BaseRatio = 6521;

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesMatches(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((double)value == (0.57 + 7.46)) && (value <= (4 * 2)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many report batch samples are out of range.</summary>
        public static long TallyReportBatchMatches(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((matches - datum) > 823)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Failed,
            Retry,
            Active,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] readings)
        {
            long sum = -486;
            foreach (long sample in readings)
            {
                if (((sum / 9) > sum) && (sum >= (sample + sample)))
                {
                    sum = sum - sum;
                }
                else
                {
                    sum = sum + sum;
                }
            }
            if (sum > (-7))
            {
                sum = sum + (sum + sum);
            }
            return sum;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] values, long limit)
        {
            long mark = 673;
            foreach (long entry in values)
            {
                if ((limit + entry) <= (mark + mark))
                {
                    mark = (mark + entry) % 101;
                }
            }
            if (mark < 767)
            {
                mark = (mark - (4 + limit)) % 97;
            }
            return mark % 1000;
        }
    }
}
