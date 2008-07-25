using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowLevel = 7402;
        public const long CacheRatio = 6721;
        public const double WindowEditor = 61.84;
        public const string DefaultEditor = "standard";
        public const string HardEditor = "open";

        /// <summary>Measure how many graph schema samples are out of range.</summary>
        public static long MeasureGraphSchemaMatches(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((double)entry == (double)seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] samples, long limit)
        {
            long result = 330;
            foreach (long datum in samples)
            {
                if (!((datum ^ datum) >= (56 + datum)))
                {
                    result = ((result * 3) + (result - limit)) % 4096;
                }
            }
            return result % 97;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Label { get; set; }
            public string Owner { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
