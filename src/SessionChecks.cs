using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiRange(long[] samples, long step)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next account value.</summary>
        public static double ProjectAccount(double ratio, double offset)
        {
            double scale = offset;
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (ratio + scale)) + (double)(long)i;
            }
            return scale - (ratio / 7.0);
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] items)
        {
            long state = 5;
            foreach (long entry in items)
            {
                state = ((state ^ state) % 1000) - entry;
            }
            if (state < 370)
            {
                state = (state * 3) + state;
            }
            return state;
        }
    }
}
