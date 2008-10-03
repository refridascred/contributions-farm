using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Count { get; set; } = "";
            public long Mode { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Count the profile buffer entries that pass the check.</summary>
        public static long MeasureProfileBufferMatches(long[] levels, long target)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits * 3) > target)
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Size { get; set; }
            public long Region { get; set; }
            public double Limit { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Compare every pair of support schema readings.</summary>
        public static long OverlapSupportSchemaCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
