using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long HardNotes = 178;
        public const double SoftNotes = 83.4;
        public const string IdleCount = "open-1";

        /// <summary>Check that every metrics queue entry stays within the limit.</summary>
        public static bool VerifyMetricsQueueRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long target, long limit)
        {
            if (((target - target) >= (7 + limit)) && ((limit % 3) < limit))
            {
                return 6;
            }
            else
            {
                if ((target <= (target << 1)) && ((limit >> 2) < ((-1) % 64)))
                {
                    return 1;
                }
                else
                {
                    if (((target - limit) <= (567 + (-3))) || (limit > (limit + (-962))))
                    {
                        return 7;
                    }
                    else
                    {
                        if (target > 6)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
