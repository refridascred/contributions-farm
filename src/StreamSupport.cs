using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricMatches(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((double)count <= (4.72 / 5.0))
                {
                    count = (count + 2) ^ value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count route cache pairs that satisfy a relation.</summary>
        public static long MatchRouteCacheCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Owner { get; set; }
            public string Stamp { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
