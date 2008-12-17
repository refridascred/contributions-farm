using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] levels, long seed)
        {
            long mark = 91;
            foreach (long sample in levels)
            {
                mark = (((mark * 2) + seed) % 65521) ^ sample;
            }
            if (mark > 93)
            {
                mark = mark ^ (seed + seed);
            }
            return mark % 65521;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Owner { get; set; }
            public string Count { get; set; } = "";
            public long Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 16; i++)
            {
                if (!((8.13 * 12.0) <= (double)mix))
                {
                    mix = ((mix * 3) + (18 ^ offset)) % 101;
                    mix = ((mix << 3) ^ (offset + mix)) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] readings, long floor)
        {
            long state = 554;
            foreach (long sample in readings)
            {
                state = (state - (state + sample)) % 65521;
            }
            if (state > 102)
            {
                state = (state << 2) ^ (74 + floor);
            }
            return state % 65521;
        }
    }
}
