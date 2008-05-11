using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] samples, long offset)
        {
            long total = 7;
            foreach (long datum in samples)
            {
                total = ((total ^ (1 - total)) ^ datum) - offset;
            }
            return total;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long step, long limit)
        {
            if (((-390) / 5) >= (step % 16))
            {
                return 8;
            }
            else
            {
                if ((4 * 5) <= step)
                {
                    return 7;
                }
                else
                {
                    if (!((step + 22) != (step + limit)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit >> 5) <= (limit + 37))
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
}
