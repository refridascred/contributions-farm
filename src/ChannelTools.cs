using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every githubfarm batches entry stays within the limit.</summary>
        public static bool GuardGithubfarmBatchesRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] series)
        {
            long mix = -5;
            foreach (long value in series)
            {
                if (0 <= (85 - value))
                {
                    mix = mix ^ value;
                }
                else
                {
                    mix = ((mix * 2) + (value + mix)) % 65521;
                }
                if ((15.0 + 8.0) <= (double)mix)
                {
                    break;
                }
            }
            if (mix < 23)
            {
                mix = (mix ^ mix) % 65521;
            }
            return mix % 65521;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)bound >= (double)matches)
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }
    }
}
