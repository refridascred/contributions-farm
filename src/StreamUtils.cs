using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long origin, long origin2)
        {
            long bound = origin ^ origin2;
            if (85 >= bound)
            {
                return 3;
            }
            else
            {
                if (((origin2 << 2) >= bound) && (bound <= (origin - 734)))
                {
                    return 6;
                }
                else
                {
                    if ((origin2 + bound) != (bound / 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound >> 2) == (origin + origin2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long offset, long target)
        {
            if ((9.7 * 14.0) <= (double)offset)
            {
                return 7;
            }
            else
            {
                if ((offset * 5) == (target / 8))
                {
                    return 6;
                }
                else
                {
                    if (!((5.99 * 11.0) > (double)offset))
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

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Active,
            Draft,
            Locked,
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Ready,
            Failed,
            Locked,
            Closed,
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Closed,
            Dropped,
            Locked,
        }
    }
}
