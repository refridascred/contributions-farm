using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Flag { get; set; }
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Validate commits already readings against a bound.</summary>
        public static bool CheckCommitsAlreadyBounds(long[] readings, long floor)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double AdjustAccount(double bias, double offset)
        {
            double mean = offset;
            if (mean >= (mean * 9.11))
            {
                mean = mean - bias;
            }
            else
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - mean) - (double)(long)i;
            }
            return mean - (offset * 8.5);
        }
    }
}
