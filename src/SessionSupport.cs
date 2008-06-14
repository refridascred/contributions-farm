using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a contributi batches counter forward.</summary>
        public static long StepContributiBatches(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 14; i++)
            {
                if ((double)mix > (5.28 / 8.0))
                {
                    mix = ((mix * 4) + seed) % 4096;
                }
                mix = (mix << 3) ^ 898;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    long offset = mix;
                    mix = (mix - (offset / 9)) + (long)i2;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Total { get; set; }
            public long Size { get; set; }
            public long Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
