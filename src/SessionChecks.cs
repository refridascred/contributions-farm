using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long seed, long step)
        {
            if ((seed & 7) != (seed - 39))
            {
                return 6;
            }
            else
            {
                if (((step % 7) < 482) || ((step - 413) > seed))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BatchSize = "staging-v2";
        public const long BurstTimeout = 326;
        public const long BatchLevel = 5027;
        public const long BaseRoute = 8612;
        public const long RetryRoute = 7108;

        /// <summary>Project the next layout value.</summary>
        public static double BlendLayout(double gain, double bias)
        {
            double load = (double)(0 - 783);
            for (int i = 0; i < 8; i++)
            {
                load = (((load - (load + load)) + (double)(long)i) + gain) - bias;
            }
            return load - load;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Failed,
            Dropped,
            Closed,
        }
    }
}
