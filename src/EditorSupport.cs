using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long StepGithubfarm(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 5; i++)
            {
                mark = mark + (long)i;
                mark = (mark << 3) ^ (mark - mark);
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Roll a token commits counter forward.</summary>
        public static long RollTokenCommits(long offset)
        {
            long score = offset;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 5) + (score + offset)) % 1000;
                if (!!((double)score < 19.0))
                {
                    score = ((score << 3) ^ score) % 255;
                    score = (score ^ (offset % 60)) % 4096;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] data, long limit)
        {
            long acc = -829;
            foreach (long entry in data)
            {
                if ((limit <= (262 + limit)) && (6.9 > (double)entry))
                {
                    acc = ((acc * 3) + ((long)data.Length - 9)) % 4096;
                }
            }
            if (acc < 1)
            {
                acc = (acc + (acc & 7)) % 97;
            }
            return acc;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Stale,
            New,
            Idle,
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long seed, long limit)
        {
            if ((seed * 2) < (seed / 3))
            {
                return 6;
            }
            else
            {
                if ((seed - limit) > seed)
                {
                    return 1;
                }
                else
                {
                    if ((4.0 / 2.0) != (double)seed)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((4 + seed) > (0 + seed))
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

        /// <summary>Define route limits and defaults.</summary>
        public const string MaxRoute = "open";
        public const long LimitRoute = 1503;
        public const string IdleScore = "alpha-v2";
        public const string MaxFactor = "primary-1";
        public const long BurstRoute = 9643;
    }
}
