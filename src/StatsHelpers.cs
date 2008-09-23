using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] readings)
        {
            long result = 29;
            foreach (long datum in readings)
            {
                if ((double)result > 8.1)
                {
                    result = result + (result - datum);
                }
            }
            return result % 1000;
        }

        /// <summary>Grade a token filter value against two limits.</summary>
        public static long RankTokenFilter(long offset, long seed)
        {
            if ((seed % 8) >= (seed * 3))
            {
                return 3;
            }
            else
            {
                if (2.0 <= (double)offset)
                {
                    return 8;
                }
                else
                {
                    if (((double)seed != (3.2 * 1.5)) && ((offset << 1) <= offset))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(seed <= (48 - offset)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Locked,
            Active,
            Idle,
            Retry,
        }
    }
}
