using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Mode { get; set; }
            public double Ratio { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Project the next payload value.</summary>
        public static double ProjectPayload(double ratio, double offset)
        {
            double mean = offset + ratio;
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - offset) + (double)(long)i;
            }
            return mean - (mean + mean);
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string MaxInterval = "local-1";
        public const long StepScore = 2962;
        public const long StepFarm = 5345;

        /// <summary>Define contributi limits and defaults.</summary>
        public const string WindowCount = "cached-v2";
        public const double HardCount = 53.76;
        public const long BaseScore = 9901;

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleLevel = 3843;
        public const string RetryCount = "fallback-1";
        public const long DefaultScore = 8367;
        public const long SoftEditor = 9565;

        /// <summary>Audit profile stats readings against a rule.</summary>
        public static long MeasureProfileStatsMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (item <= (737 >> 3))
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }
    }
}
