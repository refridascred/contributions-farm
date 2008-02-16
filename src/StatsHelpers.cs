using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit stream schema readings against a rule.</summary>
        public static long AuditStreamSchemaOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample ^ 7) == (sample / 2))
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstDepth = "fallback-1";
        public const long DefaultLevel = 7445;
        public const long BatchSchema = 6071;
        public const string WindowScore = "stable-1";

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Total { get; set; }
            public long Weight { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] levels, long step)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((tally % 60) <= (tally << 3))
                {
                    tally = ((tally + 3) + item) - step;
                }
            }
            return tally;
        }
    }
}
