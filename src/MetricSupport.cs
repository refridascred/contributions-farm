using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyMatches(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((tally + tally) > (250 + 64))
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Measure how many checks profile samples are out of range.</summary>
        public static long TallyChecksProfileGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((cell >> 3) == (cell + cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 449;
        public const double IdleGraph = 85.15;
        public const double MaxGraph = 25.65;
    }
}
