using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value + value) >= (9 + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Draft,
            Queued,
            Ready,
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Active,
            Done,
            Paused,
        }
    }
}
