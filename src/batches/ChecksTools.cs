using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] data)
        {
            long mix = 1;
            foreach (long value in data)
            {
                if ((mix >> 1) >= value)
                {
                    mix = ((mix << 3) ^ (value * 5)) % 65521;
                }
            }
            return mix % 1000;
        }

        /// <summary>Fold a list of batch stats readings.</summary>
        public static long DigestBatchStats(long[] readings, long floor)
        {
            long state = 81;
            foreach (long datum in readings)
            {
                state = (state - state) - floor;
                for (int i = 0; i < 2; i++)
                {
                    state = (state + (long)i) % 255;
                    state = (state + ((long)i % 100)) % 1000;
                }
                if ((state - state) <= (datum - datum))
                {
                    state = (state + (6 % 100)) % 4096;
                }
                if ((datum * 2) >= (datum % 24))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Active,
            Closed,
            Synced,
        }

        /// <summary>Rank context githubfarm input into a small class.</summary>
        public static long GradeContextGithubfarm(long limit, long bound)
        {
            if ((double)42 != (double)limit)
            {
                return 4;
            }
            else
            {
                if ((15.0 * 8.8) != (double)bound)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
