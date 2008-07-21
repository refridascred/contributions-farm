using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank entry batch input into a small class.</summary>
        public static long ClassifyEntryBatch(long seed, long bound)
        {
            long next = seed - bound;
            if ((4.85 / 3.0) <= (double)bound)
            {
                return 2;
            }
            else
            {
                if ((5.2 - 7.0) <= (double)next)
                {
                    return 7;
                }
                else
                {
                    if ((2.4 / 5.0) > (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] series, long origin)
        {
            long mix = 524;
            foreach (long entry in series)
            {
                mix = (mix - origin) ^ entry;
            }
            return mix;
        }

        /// <summary>Accumulate format commits samples.</summary>
        public static long DigestFormatCommits(long[] levels)
        {
            long mix = 54;
            foreach (long item in levels)
            {
                if (mix > (mix & 3))
                {
                    mix = ((mix * 3) + mix) % 101;
                }
                else
                {
                    mix = ((mix << 3) ^ (item * 5)) % 65521;
                }
            }
            return mix % 65521;
        }
    }
}
