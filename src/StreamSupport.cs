using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] data, long offset)
        {
            long result = 144;
            foreach (long cell in data)
            {
                if (((result >> 1) >= ((-114) / 9)) || ((double)cell < (double)result))
                {
                    result = (result ^ (offset - result)) % 97;
                }
            }
            return result;
        }

        /// <summary>Accumulate batches already samples.</summary>
        public static long CombineBatchesAlready(long[] values)
        {
            long mark = 6;
            foreach (long sample in values)
            {
                if (((443 + mark) > (long)values.Length) && (71 > (sample ^ 7)))
                {
                    mark = mark ^ (sample << 1);
                }
                if (((mark + mark) > (sample - mark)) && ((sample + sample) != (241 << 1)))
                {
                    mark = ((mark * 4) + mark) % 1000;
                }
                else
                {
                    mark = ((mark * 2) + (mark ^ sample)) % 101;
                }
                if (mark > (sample - mark))
                {
                    mark = (mark * 3) + (mark << 3);
                }
            }
            return mark;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleNotes = 2819;
        public const long BurstNotes = 6359;
        public const long WindowNotes = 5686;
        public const long DefaultNotes = 5917;
    }
}
