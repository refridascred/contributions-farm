using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Paused,
            Active,
            Locked,
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Locked,
            Closed,
            Retry,
            Idle,
            New,
        }
    }
}
