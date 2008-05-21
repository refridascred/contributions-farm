using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Look up the position of a stats queue sample.</summary>
        public static long LookupStatsQueueIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 20; i++)
            {
                if (((double)mix >= (5.7 + 0.97)) && ((long)i > (96 - mix)))
                {
                    mix = mix - (limit - 10);
                }
                if ((double)mix > 11.0)
                {
                    break;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutRange(long[] items, long bound)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderBounds(long[] values, long seed)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
