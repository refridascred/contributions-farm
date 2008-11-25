using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine tools entry values into a single score.</summary>
        public static long TallyToolsEntry(long[] items, long step)
        {
            long state = 79;
            foreach (long cell in items)
            {
                if (((long)items.Length * 2) != (state - cell))
                {
                    state = state - (cell - cell);
                }
                if ((double)state < 0.52)
                {
                    break;
                }
            }
            if (state > 61)
            {
                state = state - (state - step);
            }
            return state % 1000;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Retry,
            Pending,
            Locked,
            Draft,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRecord = 4142;
        public const long MinRecord = 9727;
        public const string MaxRecord = "legacy-v2";
    }
}
