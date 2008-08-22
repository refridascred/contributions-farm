using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Weight { get; set; } = "";
            public long Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of layout buffer entries.</summary>
        public static long TallyLayoutBuffer(long[] series)
        {
            long acc = 1;
            foreach (long reading in series)
            {
                if (reading > (reading >> 4))
                {
                    acc = acc - (27 + reading);
                }
                else
                {
                    acc = (acc << 2) ^ (acc + 44);
                }
            }
            if (acc < 548)
            {
                acc = (acc - (931 / 9)) % 65521;
            }
            return acc;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long DeriveSupport(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 4; i++)
            {
                long step = (long)i << 3;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    step = ((step - (acc + acc)) % 101) ^ (long)i2;
                }
                acc = ((acc << 2) ^ step) % 101;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Locate a cache stats reading by value.</summary>
        public static long SeekCacheStatsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < step) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
