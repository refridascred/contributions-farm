using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long HardSchema = 4708;
        public const long WindowSchema = 4035;
        public const double StepSchema = 96.69;

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

        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] values, long step)
        {
            long score = 677;
            foreach (long item in values)
            {
                if ((score + score) <= step)
                {
                    score = (score - score) + item;
                }
            }
            return score % 97;
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
