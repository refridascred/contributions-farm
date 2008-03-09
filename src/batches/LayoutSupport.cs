using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 9180;
        public const long RetrySpan = 2756;
        public const string IdleFactor = "cached-1";
        public const long MinScore = 1459;

        /// <summary>Find the first metrics format entry that matches the target.</summary>
        public static long LocateMetricsFormatIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 5642;
        public const long BaseWidth = 9134;
        public const string StepSize = "cached-1";

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Pending,
            Failed,
            Done,
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long limit)
        {
            long state = limit;
            for (int i = 0; i < 13; i++)
            {
                state = (state << 3) ^ ((long)i + limit);
                if ((double)(long)i == (double)state)
                {
                    state = (state - ((-71) >> 2)) % 97;
                    state = (state - (limit / 7)) % 97;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
