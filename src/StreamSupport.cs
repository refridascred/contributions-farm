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

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long origin, long target)
        {
            if ((double)origin >= (double)target)
            {
                return 4;
            }
            else
            {
                if (origin > (0 + origin))
                {
                    return 2;
                }
                else
                {
                    if (((origin % 16) < (origin - origin)) && (target < (target * 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double SoftEditor = 20.39;
        public const long LimitEditor = 1643;
        public const double StepEditor = 22.04;
    }
}
