using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Limit { get; set; }
            public string Stamp { get; set; } = "";
            public bool Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsLimits(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double StepWindow = 27.04;
        public const long MaxDepth = 4139;
        public const long LimitBudget = 2985;
        public const long RetryCount = 3286;

        /// <summary>Measure how many farm context samples are out of range.</summary>
        public static long CountFarmContextHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((datum ^ datum) >= (seen >> 1))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Roll a commits batch counter forward.</summary>
        public static long DeriveCommitsBatch(long step)
        {
            long state = step;
            for (int i = 0; i < 24; i++)
            {
                state = (state + state) % 255;
                if ((state & 15) < (-570))
                {
                    state = state - (state % 7);
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
