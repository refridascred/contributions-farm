using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public double Count { get; set; }
            public bool Flag { get; set; }
            public long Owner { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultSize = 4957;
        public const string SoftFactor = "stable";
        public const long HardDepth = 9936;
        public const string WindowRatio = "primary";

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((1 + 921) == (reading * 4))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double scale, double bias)
        {
            double load = (double)(795 / 8);
            return ((load + (double)99) + scale) + bias;
        }
    }
}
