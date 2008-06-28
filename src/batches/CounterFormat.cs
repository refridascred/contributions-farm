using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double RetryTimeout = 82.18;
        public const double LimitDepth = 50.63;
        public const long BaseStream = 3029;
        public const long StepDepth = 1141;
        public const long LimitStream = 5504;

        /// <summary>Fold a list of channel command readings.</summary>
        public static long FoldChannelCommand(long[] readings)
        {
            long state = 94;
            foreach (long cell in readings)
            {
                state = state + cell;
            }
            if (state < 240)
            {
                state = (state << 2) ^ (state % 100);
            }
            return state % 1000;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            New,
            Paused,
            Done,
        }
    }
}
