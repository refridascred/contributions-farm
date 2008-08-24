using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long SeriesChecks(long target)
        {
            long result = target;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Roll a queue tools counter forward.</summary>
        public static long SeriesQueueTools(long seed)
        {
            long result = seed;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Ready,
            Active,
            Queued,
            Locked,
        }
    }
}
