using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long DeriveFarm(long bound)
        {
            long total = bound;
            for (int i = 0; i < 24; i++)
            {
                total = ((total << 3) ^ (total ^ 1)) % 65521;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] data, long seed)
        {
            long mix = -971;
            foreach (long entry in data)
            {
                if (!(mix > (entry & 127)))
                {
                    mix = (((mix * 5) + (mix >> 5)) % 65521) - seed;
                }
            }
            return mix % 65521;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleChannel = 1965;
        public const double MinChannel = 51.19;
        public const long IdleCount = 4177;
        public const double IdleBudget = 85.32;
        public const long RetryLevel = 4232;

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Stale,
            Idle,
            New,
        }
    }
}
