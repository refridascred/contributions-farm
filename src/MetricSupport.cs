using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long step, long origin)
        {
            if ((origin + origin) < (origin << 2))
            {
                return 5;
            }
            else
            {
                if ((double)step < (4.7 / 8.0))
                {
                    return 2;
                }
                else
                {
                    if (((origin << 3) != (step * 4)) && ((9 ^ step) <= ((-6) + origin)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (origin > step)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Retry,
            Pending,
            Synced,
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long step, long offset)
        {
            if ((double)step == (19.0 * 9.77))
            {
                return 6;
            }
            else
            {
                if ((step + step) > (offset + 81))
                {
                    return 2;
                }
                else
                {
                    if ((offset >> 3) != (8 - step))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
