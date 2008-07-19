using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricMatches(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample / 2) >= (9 * 4))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Level { get; set; }
            public long Mode { get; set; }
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Count order entry pairs that satisfy a relation.</summary>
        public static long MatchOrderEntryCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
