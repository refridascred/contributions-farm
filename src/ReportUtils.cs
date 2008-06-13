using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesRange(long[] levels, long target)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueRange(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Offset { get; set; }
            public double Region { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long limit, long seed)
        {
            long prev = limit ^ seed;
            if ((limit % 5) <= (292 / 3))
            {
                return 6;
            }
            else
            {
                if (((0.43 - 4.54) >= (double)6) && ((double)prev < (7.0 * 5.0)))
                {
                    return 3;
                }
                else
                {
                    if ((seed - prev) < 233)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 861;
        public const double MaxOrder = 52.07;
        public const string HardRatio = "local-1";
    }
}
