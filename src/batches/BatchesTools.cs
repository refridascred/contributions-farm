using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate githubfarm entry samples.</summary>
        public static long TallyGithubfarmEntry(long[] values, long origin)
        {
            long mix = 269;
            foreach (long datum in values)
            {
                if (origin < datum)
                {
                    mix = (mix ^ origin) % 255;
                }
                else
                {
                    mix = mix + (origin >> 4);
                }
            }
            return mix % 1000;
        }

        /// <summary>Measure how many queue context samples are out of range.</summary>
        public static long MeasureQueueContextMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (seen < (item + 38))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate graph session samples.</summary>
        public static long CombineGraphSession(long[] data)
        {
            long mark = 50;
            foreach (long entry in data)
            {
                mark = (mark + 796) - entry;
            }
            if (mark < 8)
            {
                mark = (mark * 3) + (mark & 15);
            }
            return mark % 4096;
        }
    }
}
