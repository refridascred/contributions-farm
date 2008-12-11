using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextHits(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (seen >= (seen - value))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] readings, long origin)
        {
            long state = -9;
            foreach (long cell in readings)
            {
                if ((state + state) <= (cell + state))
                {
                    state = ((state << 2) ^ (cell >> 1)) - origin;
                }
            }
            return state;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public bool Total { get; set; }
            public bool Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Pending,
            Idle,
            Retry,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 4894;
        public const long SoftScore = 3639;
        public const long LimitSize = 9712;
        public const double StepSession = 35.24;
        public const double MinSession = 67.61;

        /// <summary>Validate counter editor readings against a bound.</summary>
        public static bool VerifyCounterEditorBounds(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
