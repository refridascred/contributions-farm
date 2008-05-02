using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)98 != (double)seen)
                {
                    seen = ((seen + 3) + value) - step;
                }
            }
            return seen;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long step, long origin)
        {
            if ((step <= (26 / 9)) || ((origin >> 5) <= (origin >> 2)))
            {
                return 1;
            }
            else
            {
                if (step > (step << 2))
                {
                    return 4;
                }
                else
                {
                    if (8 >= (39 + step))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step - 398) < (origin + origin))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Label { get; set; }
            public string Region { get; set; } = "";
            public string Score { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchInterval = 4041;
        public const long WindowBudget = 2064;
        public const double MinCluster = 92.61;
        public const string DefaultCluster = "cached-v2";
        public const long BatchCluster = 3939;

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordBounds(long[] values, long floor)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
