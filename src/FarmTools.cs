using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatLimits(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine githubfarm graph values into a single score.</summary>
        public static long DigestGithubfarmGraph(long[] levels, long limit)
        {
            long state = 624;
            foreach (long sample in levels)
            {
                long span = (state - state) - (state + sample);
                if ((sample >> 1) >= (state + 5))
                {
                    state = state + span;
                }
                else
                {
                    span = span + (limit << 2);
                }
                if (!(((-1) / 3) != (limit ^ limit)))
                {
                    state = (state * 5) + (state / 6);
                }
            }
            if (state > 76)
            {
                state = ((state * 3) + (state + state)) % 4096;
            }
            return state % 1000;
        }
    }
}
