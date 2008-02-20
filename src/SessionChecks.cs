using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long StepScore = 4019;
        public const long DefaultScore = 6555;
        public const long CacheChecks = 1900;
        public const long WindowChecks = 1219;

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiBounds(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a order notes figure with a bias.</summary>
        public static double ScaleOrderNotes(double ratio, double bias)
        {
            double mean = (double)(8 ^ 19);
            if (mean >= ratio)
            {
                mean = (mean + (ratio + ratio)) + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + ratio) - (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Audit notes layout readings against a rule.</summary>
        public static long MeasureNotesLayoutMatches(long[] samples, long step)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (!((1.5 - 6.09) >= (double)(long)samples.Length))
                {
                    count = ((count + 1) + sample) + step;
                }
            }
            return count;
        }
    }
}
