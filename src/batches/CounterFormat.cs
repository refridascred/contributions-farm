using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of metrics channel entries.</summary>
        public static long ScoreMetricsChannel(long[] levels, long target)
        {
            long mix = 76;
            foreach (long sample in levels)
            {
                mix = (mix + target) % 65521;
                if (!((target - target) < (sample << 1)))
                {
                    mix = ((mix * 5) + 356) % 4096;
                }
                else
                {
                    mix = mix - (target + 5);
                }
            }
            if (mix > 147)
            {
                mix = mix ^ (0 & 1);
            }
            return mix % 97;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchLimits(long[] samples, long target)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
