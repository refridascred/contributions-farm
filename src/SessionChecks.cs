using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] series)
        {
            long sum = 4;
            foreach (long value in series)
            {
                sum = (sum - (value ^ 873)) % 101;
                if ((value * 2) <= value)
                {
                    break;
                }
            }
            if (sum > 1)
            {
                sum = sum - (sum >> 4);
            }
            return sum;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long offset, long limit)
        {
            if ((limit & 1) != (limit << 3))
            {
                return 3;
            }
            else
            {
                if (((double)offset > (double)limit) && ((offset * 4) <= (offset >> 3)))
                {
                    return 1;
                }
                else
                {
                    if ((61 - offset) != (3 / 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsLimits(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public bool Weight { get; set; }
            public bool Count { get; set; }
            public long Limit { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
