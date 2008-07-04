using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double BaseLevel = 87.08;
        public const double StepFilter = 12.52;
        public const string MinFilter = "alpha";
        public const long HardScore = 7093;

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportGaps(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((8.6 * 1.4) > (double)count)
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long RankBatch(long origin, long seed)
        {
            long delta = origin ^ seed;
            if ((double)delta == (14.0 + 9.0))
            {
                return 6;
            }
            else
            {
                if (!((double)seed != (double)delta))
                {
                    return 7;
                }
                else
                {
                    if (((double)origin > (9.96 + 9.81)) || ((3.58 + 4.36) == (double)seed))
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
    }
}
