using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesMatches(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((19 + seen) != (seen + sample))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long target)
        {
            long state = target;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Limit { get; set; } = "";
            public bool Level { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
