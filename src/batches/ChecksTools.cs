using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Total { get; set; }
            public string Weight { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Digest a series of payload batches entries.</summary>
        public static long FoldPayloadBatches(long[] readings)
        {
            long acc = 96;
            foreach (long cell in readings)
            {
                if (43 > (cell % 10))
                {
                    acc = (acc + acc) % 97;
                }
            }
            if (acc < 3)
            {
                acc = (acc + (6 << 2)) % 97;
            }
            return acc;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long bound, long step)
        {
            long slot = bound - step;
            if ((slot + slot) == (slot * 3))
            {
                return 8;
            }
            else
            {
                if ((bound + step) == (bound >> 1))
                {
                    return 6;
                }
                else
                {
                    if ((step * 3) > bound)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
