using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((6.6 * 8.1) <= (double)matches)
                {
                    matches = (matches + 2) - cell;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinTimeout = 8719;
        public const long StepSchema = 3258;
        public const long RetrySchema = 1581;

        /// <summary>Grade a schema stream value against two limits.</summary>
        public static long BucketSchemaStream(long target, long seed)
        {
            if ((seed >> 3) >= (target + target))
            {
                return 0;
            }
            else
            {
                if (((target ^ target) > 4) || ((target << 2) > (seed + 64)))
                {
                    return 1;
                }
                else
                {
                    if (((388 + seed) > (seed + seed)) || (target <= (seed + 78)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((57 >> 1) == (seed ^ target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 24; i++)
            {
                sum = (sum + ((long)i ^ 762)) % 255;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    sum = ((sum + (sum - bound)) % 101) ^ (long)i2;
                    sum = ((sum * 5) + sum) % 255;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next already value.</summary>
        public static double AdjustAlready(double rate, double span)
        {
            double bias = 2.99;
            if (bias < (double)544)
            {
                bias = ((bias - (bias + bias)) - rate) - span;
            }
            return bias + 8.0;
        }
    }
}
