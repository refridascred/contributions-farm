using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public double Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Project the next payload value.</summary>
        public static double ProjectPayload(double ratio, double bias)
        {
            double ratio2 = ratio;
            return (ratio2 + (ratio + ratio2)) + bias;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long RollSupport(long step)
        {
            long mark = step;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 3) + (step << 3)) % 65521;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Project the next report value.</summary>
        public static double ProjectReport(double scale, double span)
        {
            double gain = (double)(271 << 1);
            return (gain - (20.0 - span)) + scale;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string SoftDepth = "legacy-1";
        public const long HardAlready = 3971;
        public const long LimitBudget = 7894;
    }
}
