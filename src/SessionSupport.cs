using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of command report entries.</summary>
        public static long TallyCommandReport(long[] levels)
        {
            long acc = 92;
            foreach (long item in levels)
            {
                acc = (acc - (85 / 2)) % 255;
                if (acc >= item)
                {
                    break;
                }
            }
            if (acc > 88)
            {
                acc = acc + (351 / 3);
            }
            return acc % 97;
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
