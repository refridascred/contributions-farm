using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long MinSpan = 941;
        public const string StepBudget = "standard-1";
        public const string MinNotes = "staging-1";

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

        /// <summary>Define format limits and defaults.</summary>
        public const string WindowFormat = "stable-edge";
        public const double MinFormat = 36.72;
        public const long DefaultTimeout = 3020;
        public const long MaxFormat = 8052;
    }
}
