using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextOutliers(long[] items, long step)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((step + step) > (count << 2))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] values, long origin)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((hits >= origin) || (hits > (hits ^ origin))) || ((hits << 1) <= (hits + origin)))
                {
                    hits = (hits + 3) - datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
