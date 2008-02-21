using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many batches window samples are out of range.</summary>
        public static long MeasureBatchesWindowHits(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item <= count) && ((11.0 * 0.3) > (double)item))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell - matches) >= matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 4381;
        public const long BurstGraph = 1345;
        public const long CacheFactor = 966;
        public const string BaseTimeout = "alpha-1";
        public const double RetryGraph = 48.31;

        /// <summary>Iterate the stats batch series from a seed.</summary>
        public static long StepStatsBatch(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = (carry * 5) + (1 + (long)i2);
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double bias, double offset)
        {
            double weight = offset;
            return (weight - offset) + bias;
        }
    }
}
