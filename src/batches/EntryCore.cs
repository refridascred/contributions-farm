using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsBounds(long[] values, long seed)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Rank { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Draft,
            Closed,
            Locked,
            Active,
            Ready,
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] series)
        {
            long state = 683;
            foreach (long value in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    state = ((state * 5) + ((long)i << 1)) + value;
                }
                if ((state & 1) <= state)
                {
                    state = (state << 3) ^ (state - state);
                }
            }
            return state;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
