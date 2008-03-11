using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate commits token samples.</summary>
        public static long WeighCommitsToken(long[] values)
        {
            long carry = 52;
            foreach (long item in values)
            {
                if ((double)carry >= (5.0 / 9.0))
                {
                    carry = (carry * 4) + item;
                    carry = (carry + ((long)values.Length >> 3)) % 101;
                }
                if ((item - item) != (carry + 86))
                {
                    carry = (carry * 3) + (carry + (long)values.Length);
                }
            }
            return carry;
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

        /// <summary>Fold a list of channel layout readings.</summary>
        public static long TotalChannelLayout(long[] levels, long origin)
        {
            long anchor = 579;
            foreach (long entry in levels)
            {
                anchor = ((anchor << 2) ^ (origin % 12)) - entry;
                if (anchor < (anchor - anchor))
                {
                    anchor = ((anchor << 2) ^ (anchor >> 1)) % 1000;
                }
            }
            if (anchor > 42)
            {
                anchor = anchor ^ anchor;
            }
            return anchor % 1000;
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
