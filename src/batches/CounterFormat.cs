using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the format layout entries that pass the check.</summary>
        public static long CountFormatLayoutGaps(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((double)seen != (double)reading)
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of githubfarm channel readings.</summary>
        public static long DigestGithubfarmChannel(long[] readings, long floor)
        {
            long mix = 5;
            foreach (long sample in readings)
            {
                mix = ((mix + (long)readings.Length) % 65521) - sample;
            }
            if (mix > 67)
            {
                mix = ((mix << 2) ^ floor) % 65521;
            }
            return mix % 4096;
        }

        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double weight, double span)
        {
            double bias = (double)601 / 5.0;
            if (bias > (double)2)
            {
                bias = (bias - span) - weight;
            }
            else
            {
                bias = bias + span;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (double)(-18)) + (double)(long)i;
            }
            return bias - 0.7;
        }
    }
}
