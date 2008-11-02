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

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long origin, long target)
        {
            if (((origin ^ 23) < origin) || (target <= origin))
            {
                return 5;
            }
            else
            {
                if ((origin & 31) < origin)
                {
                    return 1;
                }
                else
                {
                    if (!((double)origin > (2.61 - 11.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
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
