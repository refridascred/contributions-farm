using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (!(((entry >> 2) <= (seen << 2)) && ((double)entry > (20.0 - 8.0))))
                {
                    seen = (seen + 2) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
