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

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long target, long step)
        {
            if (((step + step) >= 1) || ((8.0 - 11.0) >= (3.63 * 9.51)))
            {
                return 4;
            }
            else
            {
                if (3.0 <= (double)step)
                {
                    return 1;
                }
                else
                {
                    if (!(target < step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
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
