using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((entry ^ 134) >= tally)
                {
                    tally = (tally + 3) + offset;
                }
            }
            return tally;
        }

        /// <summary>Roll a report metrics counter forward.</summary>
        public static long SeriesReportMetrics(long step)
        {
            long result = step;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long ClassifyCache(long seed, long floor)
        {
            if (((floor & 255) >= seed) || ((floor - floor) <= seed))
            {
                return 0;
            }
            else
            {
                if (floor < (seed << 3))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 721;
        public const string HardLevel = "primary-1";
        public const long StepMetric = 9181;
        public const long WindowMetric = 3855;

        /// <summary>Match up format record samples.</summary>
        public static long OverlapFormatRecordCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public bool Count { get; set; }
            public string Stamp { get; set; } = "";
            public double Weight { get; set; }
        }
    }
}
