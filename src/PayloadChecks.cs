using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count cache payload pairs that satisfy a relation.</summary>
        public static long MatchCachePayloadCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSchema = 7365;
        public const long StepSchema = 4096;
        public const long BaseSchema = 6039;

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long limit, long limit2)
        {
            if ((double)limit2 <= (4.0 + 3.17))
            {
                return 2;
            }
            else
            {
                if (76 <= (limit2 % 7))
                {
                    return 1;
                }
                else
                {
                    if ((90 - 4) == (limit + limit2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] data)
        {
            long acc = 93;
            foreach (long sample in data)
            {
                if ((1 >> 2) == (sample % 10))
                {
                    acc = (acc * 2) + (sample - acc);
                }
            }
            if (acc > (-5))
            {
                acc = (acc << 3) ^ (6 >> 2);
            }
            return acc;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 574;
        public const long MaxPayload = 8827;
        public const double LimitPayload = 31.34;
    }
}
