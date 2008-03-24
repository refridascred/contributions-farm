using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxFactor = 10.56;
        public const long MinLayout = 5471;
        public const long StepInterval = 8396;

        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double bias, double span)
        {
            double scale = bias;
            if (scale >= bias)
            {
                scale = scale + span;
            }
            return scale - (span * 4.7);
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Score { get; set; }
            public long Rank { get; set; }
            public string Offset { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Audit payload buffer readings against a rule.</summary>
        public static long AuditPayloadBufferHits(long[] items, long offset)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell + offset) < (offset / 9))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
