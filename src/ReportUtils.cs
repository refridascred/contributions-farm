using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstInterval = 5694;
        public const double BaseDepth = 35.86;
        public const double BaseBuffer = 46.94;
        public const long IdleBuffer = 6205;

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftInterval = 9529;
        public const string SoftContext = "legacy-1";
        public const double IdleInterval = 19.16;
        public const long StepScore = 7360;

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Score { get; set; }
            public bool Limit { get; set; }
            public double Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!((double)seen < (double)281))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] data)
        {
            long anchor = 0;
            foreach (long datum in data)
            {
                anchor = ((anchor * 5) + (datum * 5)) % 65521;
                for (int i = 0; i < 9; i++)
                {
                    anchor = (anchor << 3) ^ (long)i;
                }
                if (!((datum - datum) <= (anchor * 2)))
                {
                    anchor = ((anchor * 4) + (3 % 100)) % 255;
                }
                else
                {
                    anchor = ((anchor << 2) ^ anchor) % 4096;
                }
            }
            if (anchor < 90)
            {
                anchor = anchor ^ (11 - anchor);
            }
            return anchor % 4096;
        }
    }
}
