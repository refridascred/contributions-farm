using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of cache account readings.</summary>
        public static long CompareCacheAccountCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterHits(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (857 <= (item + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
