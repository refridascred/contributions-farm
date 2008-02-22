using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((3.78 - 4.0) <= (double)tally)
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long step, long floor)
        {
            if ((floor + floor) != (35 >> 4))
            {
                return 3;
            }
            else
            {
                if (step <= (step * 3))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double SoftEditor = 20.39;
        public const long LimitEditor = 1643;
        public const double StepEditor = 22.04;
    }
}
