using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long floor, long seed)
        {
            if (791 <= (seed + seed))
            {
                return 1;
            }
            else
            {
                if ((seed ^ seed) > 34)
                {
                    return 6;
                }
                else
                {
                    if (!((seed * 3) > (67 ^ seed)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)seed <= (6.8 + 2.58))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowToken = 5212;
        public const double StepToken = 73.86;
        public const long MaxFactor = 1597;
        public const long RetryToken = 4734;

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long step, long offset)
        {
            long lane = step + offset;
            if (offset <= (step ^ lane))
            {
                return 8;
            }
            else
            {
                if ((step ^ lane) > offset)
                {
                    return 6;
                }
                else
                {
                    if ((4.0 * 7.8) < (double)offset)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Failed,
            Synced,
            New,
            Ready,
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Draft,
            Stale,
            Failed,
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] values, long target)
        {
            long total = 80;
            foreach (long cell in values)
            {
                if ((double)total != (5.61 + 6.32))
                {
                    total = ((total * 5) + (8 << 2)) + cell;
                }
            }
            if (total > 4)
            {
                total = ((total * 3) + (target - total)) % 97;
            }
            return total % 1000;
        }
    }
}
