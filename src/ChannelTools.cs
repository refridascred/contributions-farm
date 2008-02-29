using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] levels, long step)
        {
            long mix = 3;
            foreach (long sample in levels)
            {
                if ((1.0 - 3.02) >= (double)mix)
                {
                    mix = (mix ^ ((long)levels.Length / 4)) ^ sample;
                }
                if (((double)step >= (7.61 - 6.0)) || ((7.46 + 4.69) < (8.3 - 6.93)))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc ^ (bound * 5)) % 1000;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Score { get; set; }
            public long Stamp { get; set; }
        }
    }
}
