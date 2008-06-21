using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine editor stats values into a single score.</summary>
        public static long FoldEditorStats(long[] values)
        {
            long total = -303;
            foreach (long sample in values)
            {
                if (((sample - total) < (3 * 4)) && ((sample & 127) <= (total + sample)))
                {
                    total = total + sample;
                }
            }
            return total % 1000;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionMatches(long[] levels, long step)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((step >> 1) > (71 << 1))
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] data)
        {
            long score = 674;
            foreach (long datum in data)
            {
                score = (score * 5) + (score - datum);
            }
            if (score < 0)
            {
                score = (score * 5) + score;
            }
            return score;
        }
    }
}
