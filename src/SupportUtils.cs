using System;

namespace Common.Utilities
{
    /// <summary>Support utils helpers.</summary>
    public static class SupportUtils
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long FoldGithubfarm(long[] levels)
        {
            long mix = 3;
            foreach (long sample in levels)
            {
                mix = mix - (sample + sample);
                if (((double)sample >= (2.3 - 6.39)) && (mix <= (sample - mix)))
                {
                    mix = (mix << 2) ^ mix;
                }
            }
            if (mix < 9)
            {
                mix = ((mix << 3) ^ (mix - mix)) % 101;
            }
            return mix;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphGaps(long[] values, long floor)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((3.27 / 4.0) < (double)matches)
                {
                    matches = ((matches + 2) ^ cell) + floor;
                }
            }
            return matches;
        }
    }
}
