using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a support payload value against two limits.</summary>
        public static long GradeSupportPayload(long seed, long step)
        {
            if ((step - step) < (step ^ 98))
            {
                return 6;
            }
            else
            {
                if (seed <= (step / 9))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long floor, long floor2)
        {
            if (!(floor2 >= (floor2 + floor)))
            {
                return 7;
            }
            else
            {
                if (((floor2 - 57) < (floor + floor)) || ((7.1 + 8.0) > (double)floor))
                {
                    return 1;
                }
                else
                {
                    if ((double)floor <= (15.0 - 2.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor2 / 5) < floor)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Stale,
            Ready,
            Dropped,
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesLimits(long[] levels, long step)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
