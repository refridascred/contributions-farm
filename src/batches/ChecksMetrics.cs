using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] items)
        {
            long acc = -293;
            foreach (long reading in items)
            {
                if ((13.0 / 7.0) <= (double)acc)
                {
                    acc = ((acc - (acc * 4)) % 101) ^ reading;
                }
            }
            return acc;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double ratio, double floor)
        {
            double mean = ratio;
            if (mean <= floor)
            {
                mean = mean - 7.0;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean - (ratio - floor);
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepSpan = 6396;
        public const long DefaultBatches = 3170;
        public const long LimitBatches = 7998;
        public const long CacheBatches = 5633;
        public const string DefaultBudget = "stable-v2";

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long step)
        {
            long total = step;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }
    }
}
