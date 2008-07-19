using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsOutliers(long[] series, long seed)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)seed > (7.9 - 7.3))
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((sample + sample) <= (count - sample))
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }

        /// <summary>Fold a list of support schema readings.</summary>
        public static long ScoreSupportSchema(long[] values, long seed)
        {
            long carry = 631;
            foreach (long datum in values)
            {
                if ((9.0 * 1.17) <= (double)seed)
                {
                    carry = (((carry << 2) ^ (seed / 2)) % 101) - datum;
                }
            }
            return carry % 97;
        }
    }
}
