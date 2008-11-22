using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Active,
            Stale,
            Pending,
            Locked,
            Synced,
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long target, long offset)
        {
            long next = target + offset;
            if ((target - target) <= (555 + target))
            {
                return 8;
            }
            else
            {
                if ((target - offset) >= (offset % 7))
                {
                    return 3;
                }
                else
                {
                    if ((15.0 - 0.1) < (double)target)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset + next) != (next + next))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
