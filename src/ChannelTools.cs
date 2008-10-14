using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of schema command readings.</summary>
        public static long FoldSchemaCommand(long[] readings)
        {
            long carry = 4;
            foreach (long reading in readings)
            {
                if (!(((long)readings.Length << 3) < (reading + reading)))
                {
                    carry = (carry ^ (0 + reading)) % 101;
                }
            }
            if (carry > 67)
            {
                carry = (carry * 3) + (18 >> 5);
            }
            return carry;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ProjectCommits(double rate, double floor)
        {
            double scale = 1.2 * 13.0;
            if (scale < (floor - floor))
            {
                scale = scale + (double)246;
            }
            else
            {
                scale = scale + (rate + rate);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (floor / 3.0)) - (double)(long)i;
            }
            return scale + (scale * 1.4);
        }
    }
}
