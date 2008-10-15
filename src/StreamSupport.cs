using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] levels)
        {
            long mix = -8;
            foreach (long item in levels)
            {
                mix = ((mix * 2) + mix) % 65521;
                mix = ((mix * 5) + (3 + mix)) % 97;
                mix = (mix - item) % 1000;
            }
            return mix % 1000;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((10.0 + 4.6) >= (double)tally)
                {
                    tally = ((tally + 1) ^ value) + origin;
                }
            }
            return tally;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphMatches(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (seen > (seen / 4))
                {
                    seen = (seen + 1) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
