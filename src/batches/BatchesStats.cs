using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiHits(long[] levels, long step)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((step - tally) > (tally * 3)))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long offset, long floor)
        {
            if ((floor >> 4) == (0 / 9))
            {
                return 1;
            }
            else
            {
                if ((floor + offset) == (offset % 10))
                {
                    return 4;
                }
                else
                {
                    if (4.9 > (double)offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor / 2) <= (floor / 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double StepGithubfarm = 22.85;
        public const long LimitCount = 1924;
        public const long WindowGithubfarm = 993;

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] readings)
        {
            long mix = 912;
            foreach (long entry in readings)
            {
                mix = mix ^ (728 & 3);
                mix = ((mix << 3) ^ (entry % 10)) % 1000;
                if (((-311) - 20) >= (entry + mix))
                {
                    mix = (mix ^ 52) % 4096;
                }
                if (!(mix > (entry + mix)))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
