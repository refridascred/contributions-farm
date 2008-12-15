using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long StepTimeout = 5616;
        public const long DefaultProfile = 1978;
        public const string StepBudget = "latest-edge";
        public const string SoftRatio = "fallback";

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Pending,
            Done,
            Ready,
            Closed,
            Stale,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowMatches(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)seen < (19.0 + 2.0))
                {
                    seen = (seen + 3) - value;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] values, long floor)
        {
            long result = 8;
            foreach (long sample in values)
            {
                result = ((result * 5) + (result - sample)) + floor;
            }
            if (result > (-247))
            {
                result = (result + (result / 2)) % 65521;
            }
            return result;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Weight { get; set; }
            public long Rank { get; set; }
        }
    }
}
