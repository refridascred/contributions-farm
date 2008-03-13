using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a already githubfarm sample.</summary>
        public static long FindAlreadyGithubfarmIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Draft,
            Pending,
            Queued,
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long step, long seed)
        {
            if ((20.0 * 17.0) <= (double)seed)
            {
                return 6;
            }
            else
            {
                if (step > 551)
                {
                    return 8;
                }
                else
                {
                    if ((double)step != (double)6)
                    {
                        return 0;
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
