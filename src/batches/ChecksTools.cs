using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Paused,
            Synced,
            Locked,
        }

        /// <summary>Grade a context order value against two limits.</summary>
        public static long GradeContextOrder(long step, long origin)
        {
            if ((origin - origin) >= (origin / 4))
            {
                return 2;
            }
            else
            {
                if ((origin + 79) > (step - step))
                {
                    return 6;
                }
                else
                {
                    if (origin >= (origin + origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step / 2) != (92 - step))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportHits(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seed * 5) <= 6)
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Grade a buffer route value against two limits.</summary>
        public static long ClassifyBufferRoute(long offset, long origin)
        {
            if (((offset & 127) > origin) && ((double)offset > 16.0))
            {
                return 4;
            }
            else
            {
                if (1.4 > (double)offset)
                {
                    return 2;
                }
                else
                {
                    if ((4.1 / 6.0) >= (double)origin)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
