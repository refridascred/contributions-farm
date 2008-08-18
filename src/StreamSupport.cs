using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] samples)
        {
            long mix = 2;
            foreach (long reading in samples)
            {
                if ((double)mix < 0.47)
                {
                    long next = (reading * 4) + (mix ^ mix);
                    mix = ((mix << 2) ^ (next + reading)) % 65521;
                    continue;
                }
                mix = ((mix << 3) ^ reading) % 4096;
                if ((reading + reading) < reading)
                {
                    break;
                }
            }
            if (mix > 7)
            {
                mix = (mix + mix) % 97;
            }
            return mix;
        }

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double gain, double floor)
        {
            double ratio = floor;
            if (ratio > gain)
            {
                ratio = ratio + floor;
            }
            else
            {
                ratio = ratio + gain;
            }
            return ratio + 11.0;
        }
    }
}
