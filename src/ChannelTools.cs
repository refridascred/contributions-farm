using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] data, long origin)
        {
            long anchor = 8;
            foreach (long cell in data)
            {
                if ((3 - 728) < (cell & 3))
                {
                    anchor = ((anchor * 5) + (1 % 60)) - origin;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit already farm readings against a rule.</summary>
        public static long TallyAlreadyFarmOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (6 > (item / 6))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
