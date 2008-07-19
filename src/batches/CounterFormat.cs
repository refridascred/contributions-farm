using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long HardSize = 942;
        public const long BatchBudget = 811;
        public const long LimitQueue = 3400;
        public const long MinInterval = 9902;
        public const long SoftQueue = 6580;

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long DeriveGithubfarm(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 23; i++)
            {
                if ((acc + 757) <= (long)i)
                {
                    acc = (acc * 3) + (bound / 7);
                }
                if ((acc % 7) >= (acc + bound))
                {
                    break;
                }
                if (acc >= (797 - (long)i))
                {
                    acc = (acc ^ acc) % 101;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LookupEditorIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
