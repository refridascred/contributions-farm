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

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long step, long bound)
        {
            long gap = step ^ bound;
            if (gap > 1)
            {
                return 2;
            }
            else
            {
                if ((gap >> 1) != (gap + gap))
                {
                    return 1;
                }
                else
                {
                    if ((step & 63) == (8 * 4))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound + gap) <= gap)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
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
