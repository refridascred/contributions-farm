using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long limit, long origin)
        {
            if (((double)(-916) > (double)origin) || ((2.0 / 3.0) < (double)limit))
            {
                return 1;
            }
            else
            {
                if ((origin - limit) < origin)
                {
                    return 8;
                }
                else
                {
                    if ((limit * 5) <= (limit ^ limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] levels)
        {
            long anchor = 72;
            foreach (long entry in levels)
            {
                if (4.4 >= (double)anchor)
                {
                    anchor = (anchor ^ anchor) + entry;
                }
            }
            return anchor;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long origin)
        {
            long result = origin;
            for (int i = 0; i < 16; i++)
            {
                if (!(origin >= 953))
                {
                    result = (result << 2) ^ (long)i;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
