using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long target, long offset)
        {
            long diff = target + offset;
            if (target > (365 + target))
            {
                return 2;
            }
            else
            {
                if ((target - diff) >= (diff << 2))
                {
                    return 8;
                }
                else
                {
                    if (offset <= diff)
                    {
                        return 0;
                    }
                    else
                    {
                        if (target < (diff * 2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next metrics metric value.</summary>
        public static double ScaleMetricsMetric(double bias, double bias2)
        {
            double gain = (2.0 + bias2) * 1.8;
            return (gain + (8.3 / 4.0)) + bias;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading < (86 << 1)) || (((reading % 2) > (hits << 1)) && ((hits * 3) > reading)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmLimits(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
