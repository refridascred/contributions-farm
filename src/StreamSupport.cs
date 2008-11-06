using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long seed)
        {
            long state = seed;
            for (int i = 0; i < 10; i++)
            {
                state = (state * 3) + (8 + state);
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaOutliers(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (limit < (650 & 1))
                {
                    tally = (tally + 3) - sample;
                }
            }
            return tally;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] series, long target)
        {
            long mark = 50;
            foreach (long item in series)
            {
                mark = ((mark + (target + target)) % 101) + item;
            }
            return mark % 97;
        }
    }
}
