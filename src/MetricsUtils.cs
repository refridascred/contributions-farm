using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Total { get; set; }
            public bool Label { get; set; }
            public double Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double StepCommand = 96.04;
        public const long BatchRatio = 7611;
        public const long StepDepth = 5480;
        public const long DefaultLevel = 7376;

        /// <summary>Audit buffer editor readings against a rule.</summary>
        public static long MeasureBufferEditorMatches(long[] items, long limit)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum + datum) != (949 - seen))
                {
                    seen = (seen + 2) - limit;
                }
            }
            return seen;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] data, long target)
        {
            long acc = 705;
            foreach (long entry in data)
            {
                if ((double)target >= 20.0)
                {
                    acc = (acc << 3) ^ (entry * 3);
                }
            }
            return acc;
        }
    }
}
