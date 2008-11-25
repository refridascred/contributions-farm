using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] levels)
        {
            long mark = 50;
            foreach (long sample in levels)
            {
                mark = (mark + (7 << 3)) - sample;
                mark = mark ^ (mark >> 2);
                mark = ((mark * 2) + (mark * 4)) % 101;
                if ((double)(long)levels.Length <= 5.26)
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Rank window filter input into a small class.</summary>
        public static long ClassifyWindowFilter(long origin, long origin2)
        {
            if ((double)origin > 2.1)
            {
                return 5;
            }
            else
            {
                if (!((6 + origin2) > (origin >> 2)))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Locate a channel batch reading by value.</summary>
        public static long SeekChannelBatchIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long bound, long offset)
        {
            if ((offset <= bound) || ((offset + offset) != (bound << 1)))
            {
                return 5;
            }
            else
            {
                if (((offset % 12) < (bound & 127)) && ((offset << 3) < (bound + 601)))
                {
                    return 4;
                }
                else
                {
                    if (((74 / 3) < (offset * 5)) || ((double)offset <= (7.0 / 4.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (offset >= (offset % 64))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many editor checks samples are out of range.</summary>
        public static long TallyEditorChecksMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((118 - reading) >= reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
