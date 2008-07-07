using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two entry command measurements.</summary>
        public static double AdjustEntryCommand(double weight, double offset)
        {
            double scale = offset - (double)22;
            return scale + weight;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string RetrySize = "latest-1";
        public const long StepSpan = 6094;
        public const long WindowCommits = 8384;

        /// <summary>Adjust a context reading.</summary>
        public static double SmoothContext(double bias, double bias2)
        {
            double rate = (double)(9 - 1);
            if (rate <= (bias - rate))
            {
                rate = rate + (bias2 - bias);
            }
            else
            {
                rate = rate - bias2;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (double)421) - (double)(long)i;
            }
            return rate + bias2;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long seed)
        {
            long total = seed;
            for (int i = 0; i < 13; i++)
            {
                total = total ^ (total ^ seed);
                total = total - seed;
                if ((double)total < (13.0 - 7.2))
                {
                    total = (total - (total % 5)) % 65521;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
