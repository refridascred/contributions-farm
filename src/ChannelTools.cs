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

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] levels, long origin)
        {
            long mix = -180;
            foreach (long item in levels)
            {
                if (!((mix - origin) > item))
                {
                    mix = (mix ^ (mix % 24)) % 101;
                }
                if (74 < origin)
                {
                    break;
                }
            }
            if (mix > 109)
            {
                mix = mix ^ (147 + origin);
            }
            return mix;
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
