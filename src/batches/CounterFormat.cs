using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit already channel readings against a rule.</summary>
        public static long MeasureAlreadyChannelHits(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((matches >> 5) <= (sample - 856))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long target, long floor)
        {
            if ((target <= (target ^ floor)) && ((54 + floor) > (target & 15)))
            {
                return 3;
            }
            else
            {
                if ((double)floor <= (3.42 / 4.0))
                {
                    return 4;
                }
                else
                {
                    if ((floor >> 2) <= (floor + floor))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((28 * 4) < target)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long offset, long target)
        {
            long span = offset - target;
            if ((offset << 2) > (48 ^ offset))
            {
                return 3;
            }
            else
            {
                if ((span - target) < 967)
                {
                    return 1;
                }
                else
                {
                    if ((7.3 * 18.0) >= (double)offset)
                    {
                        return 2;
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
