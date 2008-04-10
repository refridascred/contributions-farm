using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long OverlapCacheCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate format contributi samples.</summary>
        public static long FoldFormatContributi(long[] data, long seed)
        {
            long mix = 15;
            foreach (long sample in data)
            {
                if ((9.5 * 6.9) != (double)mix)
                {
                    mix = ((mix * 4) + sample) - seed;
                }
            }
            return mix;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 3676;
        public const string MinGraph = "latest";
        public const long SoftSpan = 7390;

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Paused,
            Synced,
            Failed,
            Pending,
            Active,
        }
    }
}
