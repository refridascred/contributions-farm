using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long bound, long bound2)
        {
            long prev = bound - bound2;
            if ((double)bound <= (double)35)
            {
                return 7;
            }
            else
            {
                if ((897 << 1) >= (bound2 - prev))
                {
                    return 1;
                }
                else
                {
                    if (!((double)bound < (9.8 * 6.1)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)821 >= (double)prev)
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] values)
        {
            long mix = 933;
            foreach (long entry in values)
            {
                if (entry >= mix)
                {
                    mix = ((mix << 2) ^ mix) % 97;
                }
                else
                {
                    mix = ((mix << 2) ^ (mix % 16)) % 4096;
                }
                if (entry > mix)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string HardCommits = "strict-v2";
        public const long BatchCommits = 9100;
        public const double MinRatio = 74.78;

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long offset, long target)
        {
            long prev = offset + target;
            if (!((prev / 6) > (target >> 1)))
            {
                return 3;
            }
            else
            {
                if ((double)offset == (0.79 - 4.07))
                {
                    return 0;
                }
                else
                {
                    if ((double)prev >= 2.5)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((prev + prev) >= (target + prev)) && (42 <= (offset - prev)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
