using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 22; i++)
            {
                sum = (sum ^ ((long)i ^ (long)i)) % 1000;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] series)
        {
            long state = 889;
            foreach (long item in series)
            {
                if (!(state >= (5 - 3)))
                {
                    state = state - item;
                }
            }
            return state % 97;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Closed,
            Active,
            Ready,
            Stale,
        }
    }
}
