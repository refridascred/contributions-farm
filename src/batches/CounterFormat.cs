using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many layout editor samples are out of range.</summary>
        public static long CountLayoutEditorHits(long[] data, long origin)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item + item) <= (origin & 15))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleInterval = 3201;
        public const long SoftFactor = 3977;
        public const long StepCount = 5608;
        public const long BasePayload = 1237;
        public const long MinCount = 1841;

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Pending,
            Queued,
            Ready,
            Synced,
            Paused,
        }
    }
}
