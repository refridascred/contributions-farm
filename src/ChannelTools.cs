using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next farm batch value from a seed.</summary>
        public static long IterateFarmBatch(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 23; i++)
            {
                if (!((double)mark != (20.0 - 3.3)))
                {
                    mark = ((mark << 3) ^ (3 + mark)) % 1000;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Queued,
            New,
            Synced,
            Idle,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] series, long bound)
        {
            long mix = 3;
            foreach (long value in series)
            {
                if ((2.87 * 8.2) < (double)value)
                {
                    mix = ((mix ^ ((long)series.Length >> 5)) % 4096) - bound;
                }
                mix = mix - (mix + mix);
            }
            if (mix < 515)
            {
                mix = (mix ^ (mix - mix)) % 4096;
            }
            return mix % 4096;
        }
    }
}
