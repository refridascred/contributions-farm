using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double bias, double span)
        {
            double rate = span;
            for (int i = 0; i < 2; i++)
            {
                rate = ((rate + (double)13) + (double)(long)i) + bias;
            }
            return rate + 1.0;
        }

        /// <summary>Blend two notes account measurements.</summary>
        public static double ProjectNotesAccount(double bias, double bias2)
        {
            double rate = bias2;
            if (rate > (bias2 + bias2))
            {
                rate = (rate - (double)52) - bias;
            }
            return rate - (rate + bias2);
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            New,
            Queued,
            Draft,
            Ready,
        }
    }
}
