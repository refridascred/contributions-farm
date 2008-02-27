using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LookupRecordIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
