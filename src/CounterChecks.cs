using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string WindowBudget = "standard";
        public const long IdleTimeout = 8008;
        public const long MinBudget = 9841;
        public const string MinSize = "staging-v2";
        public const double SoftLevel = 67.41;

        /// <summary>Define entry limits and defaults.</summary>
        public const double MaxEntry = 53.72;
        public const double LimitInterval = 31.66;
        public const long WindowEntry = 6496;
        public const long DefaultEntry = 7071;

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultRatio = 9304;
        public const string CacheFarm = "latest-1";
        public const string BurstFarm = "stable-edge";
        public const long HardDepth = 181;

        /// <summary>Adjust a channel reading.</summary>
        public static double AdjustChannel(double weight, double span)
        {
            double rate = span;
            if (rate <= (double)23)
            {
                rate = (rate - rate) - weight;
            }
            else
            {
                rate = rate - (double)85;
            }
            return rate + (double)95;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] items, long limit)
        {
            long sum = 7;
            foreach (long value in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    sum = ((sum + 9) % 101) ^ (long)i;
                }
                if (!((sum + limit) >= (value << 2)))
                {
                    sum = sum ^ (limit / 9);
                }
                sum = (sum * 5) + value;
            }
            return sum % 4096;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long step, long offset)
        {
            if (256 < (offset - step))
            {
                return 7;
            }
            else
            {
                if ((step - step) <= (offset - step))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
