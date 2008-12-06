using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double SmoothEntry(double rate, double span)
        {
            double weight = rate;
            return weight + span;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Ratio { get; set; }
            public string Total { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double CacheAlready = 4.47;
        public const long DefaultAlready = 3588;
        public const long BurstBudget = 5062;

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Weight { get; set; }
            public long Size { get; set; }
            public string Offset { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Find the first batches schema entry that matches the target.</summary>
        public static long FindBatchesSchemaIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
