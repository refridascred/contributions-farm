using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((double)item < (5.6 + 6.04))
                {
                    hits = (hits + 2) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally + tally) < value)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] values)
        {
            long result = 56;
            foreach (long sample in values)
            {
                if ((292 % 60) > (1 + result))
                {
                    result = ((result << 2) ^ (result + result)) % 65521;
                }
                else
                {
                    result = result + sample;
                }
            }
            return result;
        }
    }
}
