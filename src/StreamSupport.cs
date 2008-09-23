using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string HardSize = "latest-v2";
        public const long DefaultSchema = 4222;
        public const string BaseSchema = "primary-v2";

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesHits(long[] values, long origin)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((tally - tally) == (origin - tally))
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of command counter entries.</summary>
        public static long TallyCommandCounter(long[] series, long seed)
        {
            long mix = 3;
            foreach (long datum in series)
            {
                if ((20.0 * 20.0) > (double)datum)
                {
                    mix = (mix << 2) ^ (mix + seed);
                }
            }
            return mix % 97;
        }
    }
}
