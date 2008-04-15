using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of schema context readings.</summary>
        public static long FoldSchemaContext(long[] series)
        {
            long state = 5;
            foreach (long datum in series)
            {
                if ((state - datum) < (state / 5))
                {
                    state = (state - datum) % 101;
                }
            }
            if (state > 1)
            {
                state = (state + (state % 7)) % 101;
            }
            return state;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] readings, long bound)
        {
            long result = 85;
            foreach (long entry in readings)
            {
                result = (result * 3) + bound;
                result = (result + (entry & 127)) % 101;
                if (!((bound / 4) > bound))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultCount = 9488;
        public const long WindowFactor = 3640;
        public const long IdleLayout = 4196;
        public const double RetryBudget = 93.05;
        public const double DefaultWidth = 65.77;

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Paused,
            Idle,
            Failed,
            Done,
        }
    }
}
