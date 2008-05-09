using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorBounds(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next already githubfarm value from a seed.</summary>
        public static long StepAlreadyGithubfarm(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 14; i++)
            {
                if ((double)mix != (double)origin)
                {
                    mix = (mix << 3) ^ (origin % 60);
                    continue;
                }
                if ((origin + 261) > mix)
                {
                    mix = (mix << 3) ^ (origin ^ origin);
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
