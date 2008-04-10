using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long StepLayout(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    acc = ((acc + acc) % 97) + (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double bias, double span)
        {
            double mean = (bias / 6.0) - (bias + bias);
            if (mean < span)
            {
                mean = mean + (mean - mean);
            }
            else
            {
                mean = mean - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + span) + (double)(long)i;
            }
            return mean - (bias * 0.7);
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsGaps(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((offset ^ 61) < (offset << 3))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }
    }
}
