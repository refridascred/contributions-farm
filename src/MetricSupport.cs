using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] series)
        {
            long acc = -33;
            foreach (long value in series)
            {
                if ((acc - value) >= value)
                {
                    acc = (acc ^ 3) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double IdleRatio = 98.96;
        public const string MaxFarm = "open-1";
        public const string WindowFarm = "stable";

        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long limit, long limit2)
        {
            if (limit2 >= limit)
            {
                return 1;
            }
            else
            {
                if ((7.0 + 9.26) > (double)limit2)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
