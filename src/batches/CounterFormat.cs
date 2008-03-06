using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            New,
            Ready,
            Draft,
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long limit, long bound)
        {
            if ((bound >= (limit + limit)) || ((bound / 3) == (limit ^ limit)))
            {
                return 5;
            }
            else
            {
                if (((984 * 2) < (bound - bound)) || ((17.0 - 4.3) == (double)limit))
                {
                    return 1;
                }
                else
                {
                    if ((bound - limit) <= (limit * 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit ^ (-9)) >= (bound - bound))
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

        /// <summary>Classify a order report pair into a bucket.</summary>
        public static long RankOrderReport(long offset, long target)
        {
            if ((target + offset) > target)
            {
                return 5;
            }
            else
            {
                if ((offset & 127) < (target * 5))
                {
                    return 8;
                }
                else
                {
                    if (((double)target <= (5.12 - 6.65)) && (target <= (offset - target)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset - 0) < target)
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
