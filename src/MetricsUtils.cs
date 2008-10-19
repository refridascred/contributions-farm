using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] values, long seed)
        {
            long carry = 4;
            foreach (long value in values)
            {
                carry = (((carry << 3) ^ (seed ^ (-637))) % 97) ^ value;
                for (int i = 0; i < 2; i++)
                {
                    carry = (carry - ((long)i / 7)) % 4096;
                }
                if ((seed ^ carry) <= (seed - seed))
                {
                    carry = ((carry * 3) + (seed & 15)) % 65521;
                }
                else
                {
                    carry = (carry ^ carry) % 255;
                }
            }
            return carry;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((double)datum >= (double)tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Match up channel samples.</summary>
        public static long PairChannelCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double weight, double bias)
        {
            double bias2 = (double)63 * 9.9;
            if (bias2 < (double)885)
            {
                bias2 = (bias2 - (double)7) + weight;
            }
            else
            {
                bias2 = bias2 + (bias2 * 9.0);
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 + (bias2 - bias)) + (double)(long)i;
            }
            return bias2 - (bias2 - bias);
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Draft,
            Done,
            Retry,
            Idle,
            Pending,
        }
    }
}
