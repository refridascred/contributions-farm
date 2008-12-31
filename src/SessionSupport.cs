using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            New,
            Failed,
            Draft,
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long ClassifyGithubfarm(long origin, long limit)
        {
            long delta = origin - limit;
            if (((origin / 3) < delta) && ((9 + 11) < delta))
            {
                return 8;
            }
            else
            {
                if ((limit & 1) >= (limit >> 4))
                {
                    return 4;
                }
                else
                {
                    if (((limit + origin) >= (779 % 24)) && ((origin + limit) > (origin - delta)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((delta + limit) >= (delta & 127)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long offset, long bound)
        {
            long step = offset - bound;
            if (((bound % 3) == (step - 3)) && ((27 + 67) <= offset))
            {
                return 5;
            }
            else
            {
                if (((double)bound <= (7.2 * 0.94)) && (offset > (step % 2)))
                {
                    return 8;
                }
                else
                {
                    if (offset < (bound * 5))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
