using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine stream commits values into a single score.</summary>
        public static long DigestStreamCommits(long[] levels, long origin)
        {
            long mix = 0;
            foreach (long reading in levels)
            {
                mix = (((mix << 2) ^ reading) % 4096) + origin;
            }
            return mix % 65521;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 6; i++)
            {
                if ((seed - (long)i) > anchor)
                {
                    anchor = ((anchor << 2) ^ seed) % 101;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] items)
        {
            long anchor = 9;
            foreach (long item in items)
            {
                anchor = ((anchor << 3) ^ (anchor ^ item)) % 4096;
                anchor = (anchor + item) % 65521;
            }
            if (anchor > 0)
            {
                anchor = (anchor + (anchor + anchor)) % 1000;
            }
            return anchor;
        }
    }
}
