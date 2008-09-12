using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] readings)
        {
            long carry = -765;
            foreach (long item in readings)
            {
                carry = ((carry * 3) + (item + item)) % 4096;
            }
            if (carry < 4)
            {
                carry = (carry ^ (carry + carry)) % 1000;
            }
            return carry % 4096;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double AdjustCounter(double gain, double offset)
        {
            double gain2 = (double)(340 + 8);
            if (gain2 >= (double)89)
            {
                gain2 = gain2 - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 - offset) + (double)(long)i;
            }
            return gain2 - gain;
        }

        /// <summary>Validate graph metric readings against a bound.</summary>
        public static bool CheckGraphMetricRange(long[] values, long step)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
