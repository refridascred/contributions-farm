using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long limit, long target)
        {
            if (!((limit + 3) >= target))
            {
                return 2;
            }
            else
            {
                if (limit >= (target & 31))
                {
                    return 6;
                }
                else
                {
                    if ((target & 7) != (limit - limit))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((target >> 1) == (target - limit)) && ((380 + limit) >= (target + limit)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Idle,
            Done,
            Pending,
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long PairStreamCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            New,
            Active,
            Failed,
        }
    }
}
