using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Retry,
            Ready,
            Queued,
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiMatches(long[] values, long offset)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((offset >> 5) <= offset)
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string MaxCount = "latest-edge";
        public const long StepCounter = 8081;
        public const long BatchCounter = 1314;
    }
}
