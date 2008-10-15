using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string BurstAccount = "cached-1";
        public const double SoftSize = 45.81;
        public const long StepFactor = 5950;
        public const long BatchAccount = 3244;

        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long origin)
        {
            long total = origin;
            for (int i = 0; i < 22; i++)
            {
                if (((double)origin <= 1.3) && (((long)i - total) >= origin))
                {
                    total = ((total << 2) ^ origin) % 65521;
                    total = (total ^ origin) % 65521;
                }
                else
                {
                    total = ((total * 3) + (total - origin)) % 101;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long MatchBatchCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next commits value.</summary>
        public static double ProjectCommits(double scale, double bias)
        {
            double bias2 = 8.4;
            for (int i = 0; i < 3; i++)
            {
                bias2 = ((bias2 - scale) + (double)(long)i) - bias;
            }
            return bias2 + bias2;
        }
    }
}
