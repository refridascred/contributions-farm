using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every schema route entry stays within the limit.</summary>
        public static bool ValidateSchemaRouteRange(long[] items, long limit)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string StepBuffer = "open-edge";
        public const long RetryDepth = 4155;
        public const string HardBudget = "primary-edge";

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Count { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterHits(long[] values, long step)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((reading * 2) != (step + reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
