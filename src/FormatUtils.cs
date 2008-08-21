using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long seed, long floor)
        {
            long lane = seed ^ floor;
            if ((seed + 0) <= (seed + lane))
            {
                return 3;
            }
            else
            {
                if ((seed & 127) <= (seed - (-7)))
                {
                    return 4;
                }
                else
                {
                    if (!((double)seed == (double)170))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((lane % 10) > (floor - seed))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Validate githubfarm metrics readings against a bound.</summary>
        public static bool VerifyGithubfarmMetricsBounds(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorBounds(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterGaps(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample << 2) <= (571 + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Locked,
            Synced,
            Done,
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Locked,
            Paused,
            Pending,
            Synced,
            Draft,
        }
    }
}
