using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long target, long offset)
        {
            long diff = target - offset;
            if ((offset >= (offset - target)) && (target < (offset & 63)))
            {
                return 0;
            }
            else
            {
                if ((double)offset == (9.0 - 5.0))
                {
                    return 3;
                }
                else
                {
                    if (offset >= (6 & 63))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target + diff) >= (target * 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
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

        /// <summary>Audit route metrics readings against a rule.</summary>
        public static long TallyRouteMetricsGaps(long[] values, long seed)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (!((sample + count) > (seed & 127)) && ((count + (-668)) > (count + sample)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
