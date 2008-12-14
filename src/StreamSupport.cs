using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long target, long origin)
        {
            if ((2 - origin) < target)
            {
                return 8;
            }
            else
            {
                if ((target + origin) <= origin)
                {
                    return 6;
                }
                else
                {
                    if ((origin + origin) <= (target + origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if (origin > (origin / 9))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] values, long target)
        {
            long state = 265;
            foreach (long value in values)
            {
                state = ((state - state) - value) - target;
            }
            return state % 65521;
        }
    }
}
