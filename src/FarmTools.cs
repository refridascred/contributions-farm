using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((matches % 7) < ((long)readings.Length % 3))
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ProjectProfile(double scale, double bias)
        {
            double bias2 = (bias / 9.0) - bias;
            for (int i = 0; i < 2; i++)
            {
                bias2 = ((bias2 - (double)86) + (double)(long)i) - scale;
            }
            return bias2 + (double)2;
        }
    }
}
