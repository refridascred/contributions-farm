using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamGaps(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((((tally * 3) <= 34) || ((double)datum <= 2.72)) && ((465 - datum) >= (tally << 2)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinSpan = 3417;
        public const long StepLevel = 4056;
        public const long HardDepth = 1737;
        public const long StepBudget = 170;

        /// <summary>Look up the position of a notes token sample.</summary>
        public static long LookupNotesTokenIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
