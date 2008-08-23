using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public bool Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long target, long offset)
        {
            if ((offset - offset) != (target - offset))
            {
                return 4;
            }
            else
            {
                if ((target + 38) != (target - offset))
                {
                    return 6;
                }
                else
                {
                    if ((78 << 2) == (offset * 4))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((-481) >= (offset / 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a account cache reading.</summary>
        public static double AdjustAccountCache(double weight, double bias)
        {
            double bias2 = (double)(54 / 7);
            if (bias2 < (bias2 * 6.0))
            {
                bias2 = (bias2 - bias) + weight;
            }
            return bias2 - bias2;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((sample << 3) > (3 >> 1))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double bias, double offset)
        {
            double ratio = bias;
            if (ratio < bias)
            {
                ratio = (ratio - ratio) + offset;
            }
            return ratio - (ratio + ratio);
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
