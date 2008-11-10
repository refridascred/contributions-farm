using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Region { get; set; }
            public long Total { get; set; }
            public long Token { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((10.0 > (double)entry) || (step <= (matches - matches)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 1156;
        public const long StepCache = 6768;
        public const long BurstRatio = 512;
        public const double StepBudget = 9.19;
    }
}
