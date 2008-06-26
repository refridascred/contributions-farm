using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Active,
            Retry,
            Dropped,
            Pending,
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Ready,
            Closed,
            Pending,
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of commits format entries.</summary>
        public static long TallyCommitsFormat(long[] data, long bound)
        {
            long anchor = 7;
            foreach (long reading in data)
            {
                if ((reading + anchor) > (anchor + bound))
                {
                    anchor = ((anchor * 3) + (reading + reading)) % 65521;
                }
                else
                {
                    anchor = (anchor - (anchor / 7)) % 255;
                }
            }
            if (anchor < 847)
            {
                anchor = ((anchor * 2) + (anchor & 3)) % 1000;
            }
            return anchor;
        }

        /// <summary>Count token notes pairs that satisfy a relation.</summary>
        public static long PairTokenNotesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the stats support entries that pass the check.</summary>
        public static long MeasureStatsSupportHits(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (!(((27 % 100) <= (datum + count)) || ((count * 5) >= count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
