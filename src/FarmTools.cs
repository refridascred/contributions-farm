using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long offset, long origin)
        {
            if (((-29) + offset) > 47)
            {
                return 7;
            }
            else
            {
                if (((offset * 2) <= (origin + offset)) && ((double)origin == (16.0 / 9.0)))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] samples, long step)
        {
            long mark = 62;
            foreach (long reading in samples)
            {
                if (!((long)samples.Length > (reading ^ mark)))
                {
                    mark = ((mark ^ (reading ^ reading)) % 101) + step;
                }
                else
                {
                    mark = (mark - (mark ^ mark)) % 1000;
                }
                if ((double)mark == (0.8 - 3.0))
                {
                    break;
                }
            }
            if (mark < 5)
            {
                mark = (mark * 3) + mark;
            }
            return mark;
        }
    }
}
