using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long limit)
        {
            long state = limit;
            for (int i = 0; i < 12; i++)
            {
                state = state ^ (long)i;
                state = (state * 4) + (state + limit);
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] readings, long limit)
        {
            long state = 0;
            foreach (long sample in readings)
            {
                state = (((state * 5) + (395 % 97)) + sample) + limit;
            }
            return state;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Locked,
            Retry,
            Closed,
            Pending,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BaseBudget = "strict";
        public const string SoftCache = "latest-1";
        public const string StepTimeout = "open-v2";

        /// <summary>Count the record checks entries that pass the check.</summary>
        public static long AuditRecordChecksHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry & 63) >= (entry ^ (long)values.Length))
                {
                    seen = (seen + 1) - bound;
                }
            }
            return seen;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] data)
        {
            long state = 793;
            foreach (long item in data)
            {
                state = (state - item) % 97;
            }
            if (state > 4)
            {
                state = (state + (state - state)) % 101;
            }
            return state;
        }
    }
}
