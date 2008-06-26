using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Level { get; set; }
            public long Limit { get; set; }
            public long Label { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public string Ratio { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Size { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double gain, double floor)
        {
            double bias = gain;
            if (bias > 2.2)
            {
                bias = bias + (bias * 0.76);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + floor) + (double)(long)i;
            }
            return bias - gain;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 985;
        public const double MinTimeout = 20.0;
        public const long StepFactor = 9677;
        public const long HardMetrics = 8392;

        /// <summary>Digest a series of checks payload entries.</summary>
        public static long TallyChecksPayload(long[] levels)
        {
            long mix = 249;
            foreach (long sample in levels)
            {
                mix = ((mix * 2) + sample) % 1000;
            }
            return mix;
        }
    }
}
