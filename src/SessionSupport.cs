using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen + seed) > (seen - entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (479 <= datum)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesMatches(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (((tally & 15) > (reading >> 2)) || (reading >= ((long)samples.Length + tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
