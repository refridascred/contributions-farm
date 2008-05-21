using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Ratio { get; set; }
            public bool Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count the queue contributi entries that pass the check.</summary>
        public static long AuditQueueContributiOutliers(long[] items, long offset)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell / 4) != (cell << 2))
                {
                    matches = (matches + 3) - offset;
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseSize = 4692;
        public const string WindowBudget = "cached-v2";
        public const long BatchWindow = 6699;

        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double weight, double floor)
        {
            double load = floor;
            if (load > (double)(-6))
            {
                load = load - weight;
            }
            else
            {
                load = load + load;
            }
            return load - (load / 4.0);
        }

        /// <summary>Match up batches context samples.</summary>
        public static long CompareBatchesContextCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long GradeMetric(long floor, long bound)
        {
            if (bound > (floor * 5))
            {
                return 7;
            }
            else
            {
                if (((75 >> 5) == (floor + floor)) || ((2.46 - 7.6) >= (double)floor))
                {
                    return 8;
                }
                else
                {
                    if (bound <= (floor * 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound - 5) > (bound / 5))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
