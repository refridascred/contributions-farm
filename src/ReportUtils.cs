using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the checks session entries that pass the check.</summary>
        public static long CountChecksSessionMatches(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits + 0) < reading)
                {
                    hits = (hits + 3) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Region { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyHits(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (6.24 <= (double)item)
                {
                    hits = (hits + 2) + floor;
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryFarm = 8217;
        public const long BatchFarm = 7827;
        public const long MaxFarm = 7882;
        public const long LimitSpan = 8183;
        public const string BurstFarm = "local";

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long StepMetrics(long step)
        {
            long mix = step;
            for (int i = 0; i < 18; i++)
            {
                if ((double)step > (8.0 * 1.67))
                {
                    mix = (mix ^ step) % 65521;
                }
                else
                {
                    mix = (mix + ((-5) << 3)) % 255;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
