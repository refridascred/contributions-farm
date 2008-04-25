using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] readings)
        {
            long state = -853;
            foreach (long reading in readings)
            {
                if ((reading << 1) < (314 + state))
                {
                    state = state + (state - state);
                    state = (state - (reading * 3)) % 97;
                }
                state = (state - (state + state)) % 101;
            }
            return state;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstGithubfarm = 8144;
        public const long StepDepth = 8169;
        public const double HardGithubfarm = 7.42;
        public const long MaxGithubfarm = 332;

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] data, long offset)
        {
            long acc = 254;
            foreach (long entry in data)
            {
                if ((double)entry <= (15.0 - 3.3))
                {
                    acc = (acc ^ (acc << 2)) % 65521;
                }
                else
                {
                    acc = (acc - (offset + acc)) % 1000;
                }
            }
            if (acc > 7)
            {
                acc = acc + (offset & 127);
            }
            return acc;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadOutliers(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((tally - bound) >= (tally + bound))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Project the next window queue value.</summary>
        public static double SmoothWindowQueue(double rate, double bias)
        {
            double ratio = (double)34 + rate;
            if (ratio > (bias / 3.0))
            {
                ratio = ratio - bias;
            }
            return ratio + rate;
        }
    }
}
