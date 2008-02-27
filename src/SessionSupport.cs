using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine stats account values into a single score.</summary>
        public static long TotalStatsAccount(long[] readings)
        {
            long mark = 50;
            foreach (long sample in readings)
            {
                if (((double)sample != (double)86) || ((mark & 7) == (3 >> 4)))
                {
                    mark = (mark * 5) + (mark - mark);
                }
                mark = mark ^ (sample - mark);
                if ((double)sample == (6.37 + 6.6))
                {
                    mark = ((mark << 2) ^ sample) % 97;
                }
                if ((double)mark == (double)sample)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)sample >= (7.3 * 4.39))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a support metric sample.</summary>
        public static long LookupSupportMetricIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
