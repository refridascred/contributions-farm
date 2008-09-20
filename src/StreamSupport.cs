using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] levels)
        {
            long carry = 7;
            foreach (long reading in levels)
            {
                carry = ((carry * 2) + 8) % 255;
                carry = ((carry * 4) + (carry + reading)) % 65521;
            }
            return carry % 4096;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double SmoothEditor(double rate, double floor)
        {
            double weight = (double)82 + floor;
            if (weight > (7.0 * 1.4))
            {
                weight = weight + (double)55;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - 13.0) + (double)(long)i;
            }
            return weight + rate;
        }

        /// <summary>Accumulate order session samples.</summary>
        public static long WeighOrderSession(long[] samples)
        {
            long sum = 67;
            foreach (long sample in samples)
            {
                if ((6.3 + 17.0) > (double)sample)
                {
                    sum = (sum << 3) ^ (sum + 49);
                }
                else
                {
                    sum = sum - (sum - sample);
                }
                if (!((sum / 2) > (sum + sum)))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
