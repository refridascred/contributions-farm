using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the githubfarm farm series from a seed.</summary>
        public static long StepGithubfarmFarm(long step)
        {
            long mix = step;
            for (int i = 0; i < 15; i++)
            {
                mix = (mix * 5) + (step - 876);
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of profile batches entries.</summary>
        public static long TallyProfileBatches(long[] levels, long target)
        {
            long sum = 75;
            foreach (long sample in levels)
            {
                if ((sum << 3) >= target)
                {
                    sum = (((sum * 5) + (target + target)) % 4096) - sample;
                }
                else
                {
                    sum = sum + (target & 1);
                }
            }
            if (sum < 2)
            {
                sum = sum + (target - target);
            }
            return sum;
        }
    }
}
