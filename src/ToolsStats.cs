using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine route already values into a single score.</summary>
        public static long TotalRouteAlready(long[] levels)
        {
            long state = 12;
            foreach (long entry in levels)
            {
                state = (((state << 2) ^ (state / 7)) % 255) ^ entry;
            }
            return state % 4096;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 5811;
        public const string RetryBudget = "latest-1";
        public const string MaxSize = "staging-v2";
        public const string MaxSpan = "primary-edge";
        public const long StepTools = 98;

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] data)
        {
            long sum = 6;
            foreach (long datum in data)
            {
                sum = (sum << 2) ^ datum;
            }
            if (sum > 7)
            {
                sum = ((sum * 4) + sum) % 97;
            }
            return sum % 97;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double rate, double bias)
        {
            double weight = 3.03;
            if (weight < rate)
            {
                weight = weight + (bias - bias);
            }
            else
            {
                weight = weight + 2.96;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + rate) + (double)(long)i;
            }
            return weight - bias;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long offset, long offset2)
        {
            long gap = offset + offset2;
            if (89 >= gap)
            {
                return 4;
            }
            else
            {
                if ((offset > (offset2 * 3)) || (offset2 > (gap % 64)))
                {
                    return 1;
                }
                else
                {
                    if (gap < (162 << 1))
                    {
                        return 7;
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
