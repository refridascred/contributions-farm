using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long target, long limit)
        {
            long prev = target + limit;
            if (((target << 3) >= (prev * 5)) && ((58 + limit) < (prev & 3)))
            {
                return 1;
            }
            else
            {
                if ((4.0 / 2.0) == (double)prev)
                {
                    return 5;
                }
                else
                {
                    if ((prev + target) > target)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target + target) == (268 ^ limit))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a graph record value against two limits.</summary>
        public static long ClassifyGraphRecord(long step, long seed)
        {
            long slot = step - seed;
            if (!((step - step) <= (step + 295)))
            {
                return 3;
            }
            else
            {
                if ((slot - step) > (step - 20))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterGaps(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (((1.0 * 3.0) == (double)offset) || ((double)hits > (1.06 - 9.7)))
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }
    }
}
