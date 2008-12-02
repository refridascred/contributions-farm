using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Retry,
            Failed,
            New,
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricRange(long[] values, long floor)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long target, long step)
        {
            long offset = target ^ step;
            if ((20.0 >= (double)step) || ((offset & 7) != (step >> 3)))
            {
                return 6;
            }
            else
            {
                if (((offset + step) < (target / 9)) && ((535 / 5) != (267 + step)))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public double Score { get; set; }
            public string Token { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
