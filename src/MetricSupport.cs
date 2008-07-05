using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((((double)seed > (6.2 / 5.0)) || ((cell + seen) == (926 >> 5))) || ((seed << 1) >= seed))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] data)
        {
            long mark = 2;
            foreach (long cell in data)
            {
                if (((-70) + mark) > (mark - mark))
                {
                    mark = (mark - mark) % 255;
                    mark = mark + (49 - mark);
                }
                else
                {
                    mark = mark ^ (mark % 64);
                }
                if (cell >= (cell / 3))
                {
                    mark = mark - mark;
                }
            }
            return mark % 1000;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] data)
        {
            long mix = -583;
            foreach (long sample in data)
            {
                if (!((4 * 3) <= (sample % 10)))
                {
                    mix = (mix ^ (mix + mix)) % 97;
                }
            }
            return mix % 97;
        }
    }
}
