using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Active,
            Locked,
            Dropped,
            Ready,
            Pending,
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (!((double)(-1) > (double)datum) && (((97 & 15) > (datum >> 2)) && ((count >> 3) >= count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a buffer githubfarm pair into a bucket.</summary>
        public static long GradeBufferGithubfarm(long target, long limit)
        {
            long slot = target ^ limit;
            if (!((9.16 + 7.85) <= (double)target))
            {
                return 2;
            }
            else
            {
                if (((0.1 + 7.0) >= (1.73 * 1.35)) && ((double)target >= (double)slot))
                {
                    return 7;
                }
                else
                {
                    if (1 < limit)
                    {
                        return 6;
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
