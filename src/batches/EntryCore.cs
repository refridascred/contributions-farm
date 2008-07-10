using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double scale, double offset)
        {
            double gain = offset;
            if (gain < 9.1)
            {
                gain = gain + (double)240;
            }
            else
            {
                gain = gain - (8.1 - 20.0);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain + scale;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Active,
            Pending,
            Closed,
            New,
            Queued,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] items, long origin)
        {
            long result = 9;
            foreach (long item in items)
            {
                for (int i = 0; i < 8; i++)
                {
                    result = ((((result << 3) ^ item) % 1000) - (long)i) + origin;
                }
                result = ((result * 3) + item) % 65521;
            }
            return result;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] items, long offset)
        {
            long state = 31;
            foreach (long sample in items)
            {
                state = ((state << 3) ^ (sample - state)) - offset;
                state = (state - (sample - state)) % 65521;
                state = ((state << 2) ^ state) % 65521;
            }
            return state % 97;
        }

        /// <summary>Combine githubfarm checks values into a single score.</summary>
        public static long FoldGithubfarmChecks(long[] levels)
        {
            long mix = 311;
            foreach (long entry in levels)
            {
                if (entry > (mix ^ 8))
                {
                    mix = mix + (mix % 97);
                    continue;
                }
                for (int i = 0; i < 10; i++)
                {
                    mix = (((mix * 2) + entry) % 65521) ^ (long)i;
                }
                if ((entry << 3) >= 7)
                {
                    mix = (mix * 3) + mix;
                }
            }
            return mix % 97;
        }
    }
}
