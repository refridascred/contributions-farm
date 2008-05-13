using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultFormat = 7310;
        public const long LimitFormat = 9197;
        public const double BurstFormat = 23.0;

        /// <summary>Combine cluster entry values into a single score.</summary>
        public static long ScoreClusterEntry(long[] readings, long step)
        {
            long sum = 9;
            foreach (long datum in readings)
            {
                if (((datum + datum) > step) || (step <= (sum & 63)))
                {
                    sum = (sum * 2) + (step - step);
                }
            }
            return sum % 1000;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Stale,
            Done,
            Pending,
            Active,
        }
    }
}
