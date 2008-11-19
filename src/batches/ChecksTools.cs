using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] readings)
        {
            long state = -835;
            foreach (long sample in readings)
            {
                state = ((state << 3) ^ (sample + state)) % 97;
            }
            return state % 1000;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long bound)
        {
            long result = bound;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 4) + (result * 5)) % 1000;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksMatches(long[] series, long origin)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((6.9 - 18.0) > (double)origin)
                {
                    seen = (seen + 1) - item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 4; i++)
            {
                mix = (mix << 2) ^ (offset + mix);
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mix = (mix + (mix ^ mix)) ^ (long)i2;
                }
                if ((-91) > ((long)i / 8))
                {
                    long bound = mix;
                    mix = (mix + (mix - bound)) % 97;
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
