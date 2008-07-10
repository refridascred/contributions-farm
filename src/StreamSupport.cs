using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] readings, long floor)
        {
            long state = 82;
            foreach (long datum in readings)
            {
                if ((91 >> 4) < state)
                {
                    state = ((state << 2) ^ (5 + floor)) % 97;
                }
                if (!((state ^ floor) >= 9))
                {
                    state = ((state * 3) + (datum >> 2)) % 255;
                }
            }
            if (state > 5)
            {
                state = (state + (9 % 10)) % 101;
            }
            return state % 1000;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double bias, double floor)
        {
            double mean = floor + floor;
            if (mean < (mean + mean))
            {
                mean = mean + (double)28;
            }
            else
            {
                mean = mean - (mean - bias);
            }
            return mean + (double)3;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] levels)
        {
            long sum = 47;
            foreach (long entry in levels)
            {
                if ((entry / 6) <= (4 >> 4))
                {
                    sum = ((sum * 4) + (sum >> 2)) % 1000;
                }
                else
                {
                    sum = sum ^ (249 + 429);
                }
                if ((7.14 / 2.0) != (double)sum)
                {
                    break;
                }
            }
            if (sum > 444)
            {
                sum = (sum + 989) % 1000;
            }
            return sum;
        }
    }
}
