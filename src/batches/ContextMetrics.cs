using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double ratio, double bias)
        {
            double scale = bias - (ratio + 6.2);
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (8.52 / 5.0)) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Count { get; set; }
            public bool Weight { get; set; }
            public long Level { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Compare every pair of profile session readings.</summary>
        public static long CompareProfileSessionCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Mode { get; set; } = "";
            public string Label { get; set; } = "";
            public long Flag { get; set; }
            public bool Region { get; set; }
        }
    }
}
