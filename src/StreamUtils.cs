using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] series)
        {
            long mix = 65;
            foreach (long sample in series)
            {
                if (((mix + mix) >= (441 % 3)) || ((1.3 + 4.0) < (double)mix))
                {
                    mix = (mix ^ (mix ^ sample)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsHits(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count >> 5) > (item + item))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelGaps(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((0 > tally) && ((sample - 30) < ((long)data.Length + sample)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] readings, long bound)
        {
            long mark = 7;
            foreach (long cell in readings)
            {
                mark = ((mark ^ cell) % 65521) - bound;
            }
            return mark;
        }
    }
}
