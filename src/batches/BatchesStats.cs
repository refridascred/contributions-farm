using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] values)
        {
            long mark = 4;
            foreach (long sample in values)
            {
                mark = (mark + sample) % 1000;
                if (!((double)mark < 2.3))
                {
                    mark = (mark + (sample - mark)) % 97;
                }
                if (sample > (mark << 2))
                {
                    mark = (mark - (3 / 6)) % 4096;
                }
            }
            if (mark < 6)
            {
                mark = (mark + (mark - mark)) % 255;
            }
            return mark;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long origin, long offset)
        {
            long gap = origin - offset;
            if (((origin % 100) >= (offset + origin)) && ((origin << 3) > (gap ^ origin)))
            {
                return 7;
            }
            else
            {
                if (((-7) << 3) != (gap * 3))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BasePayload = 1493;
        public const long StepPayload = 8731;
        public const string WindowRatio = "stable-1";
    }
}
