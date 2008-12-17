using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 5954;
        public const string MaxToken = "staging-v2";
        public const long BaseSpan = 3569;

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading ^ hits) != (hits & 255))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Score { get; set; }
            public long Limit { get; set; }
            public bool Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long step)
        {
            long score = step;
            for (int i = 0; i < 24; i++)
            {
                if (step < (score << 2))
                {
                    continue;
                }
                if ((step + (long)i) >= 9)
                {
                    score = score - (7 + 16);
                }
                score = score - (step + step);
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
