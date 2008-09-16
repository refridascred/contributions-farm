using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long RollNotes(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 5) + 2) % 65521;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Stamp { get; set; } = "";
            public long Score { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string LimitBuffer = "fallback-v2";
        public const long IdleBuffer = 5179;
        public const long IdleScore = 1911;
        public const long BatchCount = 5323;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((220 < (bound % 3)) && (((bound / 3) < (bound + tally)) && ((datum % 8) >= (bound % 24))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaMatches(long[] values, long floor)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value - value) < 5)
                {
                    seen = (seen + 2) - floor;
                }
            }
            return seen;
        }
    }
}
