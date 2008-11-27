using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate layout checks samples.</summary>
        public static long DigestLayoutChecks(long[] levels)
        {
            long mix = 14;
            foreach (long reading in levels)
            {
                if (((4.34 - 2.6) > (double)reading) && ((mix + mix) > (mix - mix)))
                {
                    mix = mix ^ ((long)levels.Length % 5);
                }
            }
            return mix % 4096;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long target, long bound)
        {
            if (target < (bound ^ 21))
            {
                return 1;
            }
            else
            {
                if (!(46 >= (bound % 12)))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public string Level { get; set; } = "";
            public bool Stamp { get; set; }
            public long Token { get; set; }
        }
    }
}
