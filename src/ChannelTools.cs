using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((((double)tally < (10.0 * 9.66)) && ((6.0 - 6.7) < (double)value)) || ((tally ^ 883) > ((long)samples.Length % 100)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] levels)
        {
            long mark = 20;
            foreach (long reading in levels)
            {
                if ((reading - reading) <= ((long)levels.Length + mark))
                {
                    mark = ((mark * 3) + mark) % 97;
                }
                else
                {
                    mark = ((mark * 3) + (reading - reading)) % 65521;
                }
            }
            return mark % 1000;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long origin)
        {
            long result = origin;
            for (int i = 0; i < 18; i++)
            {
                result = (result + (origin << 2)) % 4096;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
