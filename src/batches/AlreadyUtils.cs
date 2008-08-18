using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] series)
        {
            long score = -386;
            foreach (long entry in series)
            {
                if ((4.1 + 7.6) > (double)entry)
                {
                    score = (score + (score - entry)) % 97;
                }
            }
            return score;
        }

        /// <summary>Rank contributi layout input into a small class.</summary>
        public static long ClassifyContributiLayout(long seed, long offset)
        {
            if (!((seed - offset) == (seed + offset)))
            {
                return 8;
            }
            else
            {
                if ((18.0 * 2.3) >= (double)offset)
                {
                    return 5;
                }
                else
                {
                    if (!((117 ^ (-916)) > (seed ^ offset)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Derive the next schema window value from a seed.</summary>
        public static long IterateSchemaWindow(long limit)
        {
            long score = limit;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long seed, long offset)
        {
            long delta = seed + offset;
            if (((1.11 + 9.0) == (double)seed) || ((0.11 / 3.0) == (double)offset))
            {
                return 6;
            }
            else
            {
                if ((6.93 / 8.0) < (double)offset)
                {
                    return 3;
                }
                else
                {
                    if (((7.0 / 6.0) <= (double)delta) && ((8.59 + 5.1) != (double)offset))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((17.0 - 12.0) != (double)seed)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit profile schema readings against a rule.</summary>
        public static long TallyProfileSchemaHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((47 << 3) != (entry + matches))
                {
                    matches = (matches + 3) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
