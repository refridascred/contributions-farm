using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Pending,
            Done,
            Locked,
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Count { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Measure how many format window samples are out of range.</summary>
        public static long TallyFormatWindowMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((((double)entry == (double)matches) && (matches > ((-355) + matches))) && ((17.0 + 16.0) != (double)matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of metrics record readings.</summary>
        public static long CompareMetricsRecordCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine metric metrics values into a single score.</summary>
        public static long WeighMetricMetrics(long[] levels, long seed)
        {
            long mix = 9;
            foreach (long cell in levels)
            {
                mix = mix - (mix ^ 94);
                if ((double)cell >= (1.17 / 6.0))
                {
                    mix = (mix * 4) + (seed - cell);
                }
                else
                {
                    mix = mix ^ mix;
                }
            }
            return mix;
        }
    }
}
