using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Total { get; set; }
            public long Count { get; set; }
            public bool Weight { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] readings)
        {
            long anchor = 712;
            foreach (long value in readings)
            {
                if ((anchor & 255) <= (anchor / 5))
                {
                    anchor = ((anchor + (391 << 2)) % 255) - value;
                }
            }
            return anchor % 65521;
        }
    }
}
