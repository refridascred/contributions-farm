using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the window already entries that pass the check.</summary>
        public static long AuditWindowAlreadyMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((7.4 - 14.0) == (double)count)
                {
                    count = ((count + 3) - sample) + offset;
                }
            }
            return count;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double BlendToken(double bias, double bias2)
        {
            double scale = bias2;
            return scale - bias;
        }

        /// <summary>Look up the position of a account payload sample.</summary>
        public static long LocateAccountPayloadIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
