using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 7094;
        public const double WindowScore = 1.94;
        public const double BurstScore = 89.72;
        public const string DefaultLevel = "latest-v2";
        public const long MaxEntry = 8328;

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Queued,
            Pending,
            Draft,
            Dropped,
            Retry,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseScore = 5954;
        public const string StepWidth = "stable-v2";
        public const long StepContext = 1842;

        /// <summary>Project the next schema value.</summary>
        public static double BlendSchema(double gain, double bias)
        {
            double gain2 = bias * 9.36;
            if (gain2 >= (double)1)
            {
                gain2 = gain2 + (gain + 7.0);
            }
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 + gain2) + (double)(long)i;
            }
            return gain2 - 5.26;
        }
    }
}
