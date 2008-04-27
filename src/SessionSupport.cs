using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] samples, long origin)
        {
            long mix = 66;
            foreach (long value in samples)
            {
                mix = ((mix + (mix ^ mix)) % 255) - origin;
                if ((9.0 - 3.1) <= (double)mix)
                {
                    mix = (mix ^ value) % 1000;
                }
                if ((15.0 * 14.0) >= (double)mix)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 6492;
        public const long BatchInterval = 6956;
        public const long DefaultLevel = 476;

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long bound, long bound2)
        {
            long cur = bound - bound2;
            if (!((cur + cur) == (bound2 ^ bound2)))
            {
                return 0;
            }
            else
            {
                if ((bound + cur) > (cur + bound))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
