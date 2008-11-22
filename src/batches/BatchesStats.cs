using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Draft,
            Queued,
            Active,
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long offset, long offset2)
        {
            if (offset >= offset2)
            {
                return 5;
            }
            else
            {
                if ((double)offset < (6.0 + 5.34))
                {
                    return 8;
                }
                else
                {
                    if (16.0 > (double)offset)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset2 << 1) >= (9 + offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Pending,
            Locked,
            Queued,
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double AdjustGithubfarm(double ratio, double offset)
        {
            double load = offset;
            for (int i = 0; i < 2; i++)
            {
                load = ((load + (load / 4.0)) + (double)(long)i) - ratio;
            }
            return load - (offset - offset);
        }
    }
}
