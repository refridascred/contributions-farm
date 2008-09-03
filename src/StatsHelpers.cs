using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Stamp { get; set; }
            public double Offset { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Offset { get; set; }
            public string Label { get; set; } = "";
            public double Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Audit editor context readings against a rule.</summary>
        public static long MeasureEditorContextGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (20.0 < (double)(long)readings.Length)
                {
                    tally = ((tally + 3) - datum) - floor;
                }
            }
            return tally;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteLimits(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
