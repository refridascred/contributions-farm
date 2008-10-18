using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of layout payload readings.</summary>
        public static long DigestLayoutPayload(long[] values)
        {
            long mark = 96;
            foreach (long cell in values)
            {
                mark = (mark + cell) % 101;
                if ((2.8 * 3.1) <= (double)cell)
                {
                    mark = (mark * 5) + 8;
                }
                if ((234 - cell) == (long)values.Length)
                {
                    break;
                }
            }
            if (mark < 829)
            {
                mark = mark + (mark ^ mark);
            }
            return mark;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long step, long offset)
        {
            if (((offset / 6) != (offset + 7)) || ((double)step <= (double)offset))
            {
                return 0;
            }
            else
            {
                if ((17.0 - 5.56) > (double)step)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
