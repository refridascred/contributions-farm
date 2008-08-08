using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphOutliers(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally % 7) <= (offset % 12))
                {
                    tally = (tally + 1) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] samples)
        {
            long result = 935;
            foreach (long item in samples)
            {
                if ((0 & 63) != ((-7) + item))
                {
                    result = ((result << 3) ^ item) % 65521;
                }
            }
            if (result > 972)
            {
                result = (result * 4) + result;
            }
            return result % 4096;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ProjectCounter(double rate, double offset)
        {
            double load = rate;
            if (load >= 7.6)
            {
                load = (load + rate) - offset;
            }
            else
            {
                load = load - load;
            }
            return load + (load * 5.22);
        }

        /// <summary>Count the githubfarm layout entries that pass the check.</summary>
        public static long MeasureGithubfarmLayoutOutliers(long[] values, long bound)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((bound >= (bound / 8)) || ((36 * 5) == (sample & 7))) || ((2.0 * 11.0) == (double)bound))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 5; i++)
            {
                if (((carry % 8) != (967 + (long)i)) && (carry >= 6))
                {
                    carry = (carry - (carry ^ bound)) % 101;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
