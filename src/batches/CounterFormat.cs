using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] data, long limit)
        {
            long state = 210;
            foreach (long reading in data)
            {
                if ((reading > limit) || ((0 / 9) < (limit - 829)))
                {
                    state = (state * 5) + (434 + state);
                }
                else
                {
                    state = (state ^ 95) % 65521;
                }
            }
            return state;
        }

        /// <summary>Count window command pairs that satisfy a relation.</summary>
        public static long MatchWindowCommandCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Owner { get; set; }
            public bool Total { get; set; }
        }
    }
}
