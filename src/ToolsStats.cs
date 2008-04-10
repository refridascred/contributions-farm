using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long HardTimeout = 4720;
        public const long IdleBudget = 5455;
        public const long RetryProfile = 5343;
        public const long CacheProfile = 3995;

        /// <summary>Fold a list of filter channel readings.</summary>
        public static long DigestFilterChannel(long[] items)
        {
            long state = 26;
            foreach (long sample in items)
            {
                if (((4.26 * 5.2) != (double)sample) && (sample <= (sample ^ state)))
                {
                    continue;
                }
                if ((state << 2) > (state + state))
                {
                    break;
                }
                state = ((state * 4) + (state << 1)) % 97;
            }
            return state;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Active,
            Pending,
            Idle,
            Closed,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricMatches(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (((limit + reading) <= (tally + 295)) && (reading > (84 << 2)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Scale a order batches figure with a bias.</summary>
        public static double ScaleOrderBatches(double weight, double bias)
        {
            double weight2 = bias;
            if (weight2 > weight2)
            {
                weight2 = (weight2 + (double)6) - weight;
            }
            return weight2 - (bias / 6.0);
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountGaps(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (!((8.3 + 3.0) > (double)datum))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
