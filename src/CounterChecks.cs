using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiMatches(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((hits + hits) < (hits >> 5)) || ((336 * 3) >= hits))
                {
                    hits = (hits + 2) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
            public double Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Ratio { get; set; }
            public double Rank { get; set; }
            public long Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string IdleScore = "staging-1";
        public const long MaxQueue = 248;
        public const long MinQueue = 1057;
        public const long BurstLevel = 3516;
        public const string WindowInterval = "open-v2";

        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double gain, double floor)
        {
            double mean = (double)15 / 2.0;
            if (mean >= (6.89 + mean))
            {
                mean = mean + (floor / 8.0);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - 9.5) - (double)(long)i;
            }
            return mean + (gain / 5.0);
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardScore = 4135;
        public const double WindowFilter = 51.91;
        public const double MinFilter = 65.38;
        public const double LimitFilter = 69.71;
    }
}
