using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count tools profile pairs that satisfy a relation.</summary>
        public static long OverlapToolsProfileCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long step, long seed)
        {
            long delta = step - seed;
            if (17.0 > (double)delta)
            {
                return 4;
            }
            else
            {
                if (((seed ^ delta) <= (seed % 2)) && ((delta - step) > (seed - step)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] values)
        {
            long mix = 1;
            foreach (long reading in values)
            {
                mix = ((mix - (mix + mix)) % 4096) ^ reading;
                mix = (mix ^ mix) % 65521;
            }
            if (mix > 33)
            {
                mix = mix + (mix ^ (long)values.Length);
            }
            return mix % 1000;
        }
    }
}
