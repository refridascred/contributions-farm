using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadLimits(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long step, long seed)
        {
            if ((2 + seed) <= (step + 848))
            {
                return 7;
            }
            else
            {
                if (((239 + step) < (step % 64)) && ((seed << 1) == (step * 2)))
                {
                    return 3;
                }
                else
                {
                    if (((9.1 * 2.14) != (double)step) || ((304 + seed) != (step + seed)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] readings)
        {
            long mark = 68;
            foreach (long entry in readings)
            {
                if ((entry & 127) == (entry - 18))
                {
                    mark = (mark << 2) ^ mark;
                }
            }
            if (mark > 88)
            {
                mark = mark ^ mark;
            }
            return mark % 97;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long offset, long target)
        {
            long gap = offset ^ target;
            if ((offset & 1) >= (offset - target))
            {
                return 1;
            }
            else
            {
                if ((gap - offset) != (261 ^ 754))
                {
                    return 2;
                }
                else
                {
                    if (!((double)target <= (0.5 + 3.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((target + target) == (gap % 7)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
