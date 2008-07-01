using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorHits(long[] values, long offset)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((matches & 31) > (offset << 3))
                {
                    matches = (matches + 3) - datum;
                }
            }
            return matches;
        }

        /// <summary>Rank editor already input into a small class.</summary>
        public static long RankEditorAlready(long bound, long origin)
        {
            long delta = bound + origin;
            if ((origin + delta) >= (bound + origin))
            {
                return 4;
            }
            else
            {
                if ((delta - origin) <= (origin & 15))
                {
                    return 5;
                }
                else
                {
                    if ((bound + 32) <= origin)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)delta == (1.02 * 1.5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Token { get; set; }
            public long Weight { get; set; }
            public long Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Failed,
            Closed,
            Draft,
            Idle,
            Locked,
        }
    }
}
