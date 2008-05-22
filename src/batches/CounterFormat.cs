using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Draft,
            New,
            Dropped,
            Idle,
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphHits(long[] data, long step)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)step > (double)datum)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 7910;
        public const long MinToken = 142;
        public const long BatchSpan = 5343;
    }
}
