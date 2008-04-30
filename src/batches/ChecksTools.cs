using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long target, long target2)
        {
            long bound = target - target2;
            if ((bound + 448) >= (target2 << 2))
            {
                return 5;
            }
            else
            {
                if ((target / 9) >= bound)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsBounds(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Region { get; set; }
            public long Ratio { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Rank githubfarm tools input into a small class.</summary>
        public static long BucketGithubfarmTools(long origin, long limit)
        {
            if ((origin < (origin - 5)) || ((limit - origin) <= limit))
            {
                return 6;
            }
            else
            {
                if ((origin >> 3) != (limit + limit))
                {
                    return 2;
                }
                else
                {
                    if (3 >= (origin + 677))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)origin >= 9.55)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
