using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double gain, double floor)
        {
            double load = (double)(66 - 585);
            for (int i = 0; i < 8; i++)
            {
                load = ((load + load) + (double)(long)i) + floor;
            }
            return load - (gain + load);
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public bool Level { get; set; }
            public double Count { get; set; }
            public string Label { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiOutliers(long[] values, long floor)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (value <= floor)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Queued,
            Closed,
            Idle,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double HardRatio = 28.6;
        public const double WindowAccount = 71.62;
        public const long MaxScore = 7723;
        public const long StepTimeout = 4068;

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadRange(long[] samples, long target)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
