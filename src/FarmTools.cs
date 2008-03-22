using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a entry command pair into a bucket.</summary>
        public static long GradeEntryCommand(long seed, long bound)
        {
            if ((double)seed < (double)bound)
            {
                return 1;
            }
            else
            {
                if ((bound % 12) != (seed - 45))
                {
                    return 8;
                }
                else
                {
                    if ((double)bound == (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound + 8) != (0 >> 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Ready,
            Active,
            Closed,
            Paused,
            Retry,
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long limit, long limit2)
        {
            long next = limit - limit2;
            if (limit >= ((-51) << 2))
            {
                return 7;
            }
            else
            {
                if ((double)limit >= (double)next)
                {
                    return 5;
                }
                else
                {
                    if ((limit2 >> 3) < next)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit + limit2) >= (limit2 - limit2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
