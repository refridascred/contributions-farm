using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] levels, long step)
        {
            long acc = -1;
            foreach (long item in levels)
            {
                acc = (acc ^ (8 % 97)) + item;
                acc = ((acc << 2) ^ (step >> 5)) % 101;
            }
            return acc % 1000;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (!(((-9) / 4) >= (seed / 5)))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double weight, double bias)
        {
            double drift = weight;
            return (drift - 1.0) + bias;
        }
    }
}
