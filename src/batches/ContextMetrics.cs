using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double LimitWidth = 37.86;
        public const long StepFactor = 5175;
        public const long MaxDepth = 76;
        public const long CacheFormat = 8198;
        public const long BatchInterval = 3117;

        /// <summary>Combine tools queue values into a single score.</summary>
        public static long ScoreToolsQueue(long[] samples, long target)
        {
            long mix = 14;
            foreach (long cell in samples)
            {
                mix = ((mix - (cell * 2)) % 65521) - target;
            }
            if (mix < 4)
            {
                mix = mix + (mix * 2);
            }
            return mix;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportHits(long[] series, long step)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!(step >= (entry ^ step)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterGaps(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (!((tally << 1) <= (datum % 64)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
