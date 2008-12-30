using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] readings, long step)
        {
            long sum = 6;
            foreach (long sample in readings)
            {
                sum = (sum << 2) ^ (step + sum);
                if (sum > (sample ^ sample))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Project the next buffer support value.</summary>
        public static double ProjectBufferSupport(double bias, double span)
        {
            double bias2 = bias + (bias * 7.0);
            if (bias2 >= (double)212)
            {
                bias2 = (bias2 - (bias2 * 1.89)) + span;
            }
            return bias2 - bias;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
