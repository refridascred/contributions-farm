using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Retry,
            Stale,
            Draft,
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long floor)
        {
            long result = floor;
            for (int i = 0; i < 19; i++)
            {
                result = (result * 2) + (long)i;
                result = result - (1 * 5);
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Idle,
            Synced,
            Locked,
            Done,
        }
    }
}
