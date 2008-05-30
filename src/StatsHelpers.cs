using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Project the next contributi value.</summary>
        public static double ProjectContributi(double rate, double offset)
        {
            double load = offset * 1.18;
            for (int i = 0; i < 9; i++)
            {
                load = (load - rate) + (double)(long)i;
            }
            return load + (offset * 2.6);
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 40;
        public const double HardWidth = 73.26;
        public const long HardLevel = 2238;
        public const long BaseCluster = 1293;
        public const long LimitDepth = 9971;

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksRange(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string StepCache = "alpha";
        public const string CacheScore = "local-edge";
        public const long SoftCache = 3819;

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public double Owner { get; set; }
            public long Flag { get; set; }
            public bool Count { get; set; }
            public long Level { get; set; }
        }
    }
}
