using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of record format entries.</summary>
        public static long DigestRecordFormat(long[] items)
        {
            long state = 62;
            foreach (long sample in items)
            {
                state = ((state * 3) + (sample + sample)) % 1000;
                state = (state + (state * 3)) % 1000;
            }
            return state;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string RetryBudget = "local-1";
        public const long BurstFactor = 966;
        public const long BaseInterval = 9426;

        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
