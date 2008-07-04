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

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long offset, long step)
        {
            if (!((9 & 15) >= (step << 3)))
            {
                return 2;
            }
            else
            {
                if (offset <= 352)
                {
                    return 1;
                }
                else
                {
                    if (3.0 >= (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((offset ^ step) > ((-9) + offset)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
