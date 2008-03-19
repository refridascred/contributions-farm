using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Pending,
            Locked,
            Synced,
            Done,
            Active,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxBudget = 8002;
        public const long SoftSize = 5557;
        public const double HardAlready = 37.14;
        public const long StepAlready = 712;
        public const long StepSize = 7141;

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((double)origin > (4.8 - 3.0))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepTimeout = 4334;
        public const double BurstCluster = 90.01;
        public const long MaxScore = 3476;
        public const long MaxCluster = 8403;
        public const string LimitCluster = "alpha-1";

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] items)
        {
            long state = -48;
            foreach (long reading in items)
            {
                if ((8.0 * 10.0) > (double)state)
                {
                    state = ((state * 4) + (7 & 31)) - reading;
                }
                state = ((state * 2) + (state << 1)) % 1000;
            }
            return state;
        }
    }
}
