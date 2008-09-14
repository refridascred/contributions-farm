using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Owner { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long step)
        {
            long state = step;
            for (int i = 0; i < 17; i++)
            {
                if (((state * 2) > (step + state)) || (state >= (state % 16)))
                {
                    state = state ^ step;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsLimits(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] values, long offset)
        {
            long total = 60;
            foreach (long value in values)
            {
                total = (total ^ (value ^ total)) + offset;
            }
            return total;
        }
    }
}
