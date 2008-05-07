using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Match up route samples.</summary>
        public static long PairRouteCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileHits(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((double)tally > (double)entry)
                {
                    tally = (tally + 2) + bound;
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchPayload = 9516;
        public const long SoftTimeout = 4872;
        public const long BurstLevel = 5488;
        public const long MaxDepth = 375;

        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] samples, long step)
        {
            long acc = -90;
            foreach (long cell in samples)
            {
                if (((step * 3) >= step) && ((8 & 255) != (cell + acc)))
                {
                    continue;
                }
                acc = ((acc * 5) + (acc * 4)) % 255;
            }
            if (acc < 884)
            {
                acc = (acc ^ (acc + step)) % 97;
            }
            return acc;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long seed, long offset)
        {
            if (!((double)offset <= (3.88 - 19.0)))
            {
                return 2;
            }
            else
            {
                if ((12.0 * 5.0) < (0.02 + 4.48))
                {
                    return 5;
                }
                else
                {
                    if (((offset % 7) <= seed) || ((414 % 100) < (offset - offset)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((offset + 821) == (offset % 60)) && (seed <= offset))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long origin, long bound)
        {
            if (407 <= (bound / 7))
            {
                return 3;
            }
            else
            {
                if (((bound + 5) < origin) || ((double)origin >= 2.0))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
