using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] series)
        {
            long mark = 77;
            foreach (long cell in series)
            {
                mark = mark - ((long)series.Length ^ cell);
                if (!((202 - cell) >= (cell - (long)series.Length)))
                {
                    mark = (mark * 3) + (long)series.Length;
                }
            }
            if (mark > 9)
            {
                mark = (mark - mark) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long seed)
        {
            long state = seed;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmOutliers(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (((589 <= (seen & 15)) && (reading <= (reading + reading))) || ((reading >> 4) <= reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
