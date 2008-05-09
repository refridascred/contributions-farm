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

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long limit, long seed)
        {
            long step = limit - seed;
            if ((step & 3) < (-468))
            {
                return 6;
            }
            else
            {
                if ((double)88 != (double)seed)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
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
