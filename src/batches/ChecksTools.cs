using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Locked,
            Done,
            Closed,
        }

        /// <summary>Rank farm record input into a small class.</summary>
        public static long SortFarmRecord(long limit, long bound)
        {
            if ((bound >> 4) < (limit / 8))
            {
                return 0;
            }
            else
            {
                if ((limit + limit) != (6 + limit))
                {
                    return 7;
                }
                else
                {
                    if (!((limit ^ limit) != (bound + limit)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (5.06 < (double)bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long origin, long target)
        {
            long edge = origin + target;
            if ((1 >> 1) <= (edge + origin))
            {
                return 8;
            }
            else
            {
                if ((origin > edge) || ((target ^ origin) <= (origin - 75)))
                {
                    return 0;
                }
                else
                {
                    if (((double)origin >= (double)target) || ((edge >> 1) <= (origin >> 1)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((edge * 5) < (edge - 486))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileBounds(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
