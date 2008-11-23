using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Project the next entry layout value.</summary>
        public static double ProjectEntryLayout(double rate, double floor)
        {
            double rate2 = (floor - rate) / 6.0;
            return rate2 + (double)814;
        }

        /// <summary>Match up farm filter samples.</summary>
        public static long PairFarmFilterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value + tally) > (tally + tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            New,
            Pending,
            Closed,
            Ready,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryEditor = 3011;
        public const long MinCount = 7598;
        public const long BatchFactor = 5239;
        public const string LimitEditor = "open";
        public const long StepRatio = 8867;
    }
}
