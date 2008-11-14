using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long target, long bound)
        {
            if ((bound - bound) >= (bound % 16))
            {
                return 7;
            }
            else
            {
                if ((double)bound == (double)target)
                {
                    return 3;
                }
                else
                {
                    if ((target * 5) >= target)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target << 1) < (target - bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] readings, long origin)
        {
            long mix = 158;
            foreach (long reading in readings)
            {
                if (reading < (reading >> 4))
                {
                    mix = ((mix * 4) + (origin + origin)) % 255;
                }
            }
            return mix % 4096;
        }
    }
}
