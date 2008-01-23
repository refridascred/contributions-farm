using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many format support samples are out of range.</summary>
        public static long TallyFormatSupportOutliers(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample + 853) == (sample * 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Limit { get; set; }
            public long Token { get; set; }
            public long Total { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphGaps(long[] values, long bound)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((bound * 4) > (-51))
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }
    }
}
