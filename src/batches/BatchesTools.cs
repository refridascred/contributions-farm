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

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long MatchEntryCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
