using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double bias, double offset)
        {
            double gain = (double)(5 << 3);
            if (gain <= (double)25)
            {
                gain = (gain + (double)4) + bias;
            }
            else
            {
                gain = gain - (offset - 5.5);
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (offset / 6.0)) + (double)(long)i;
            }
            return gain + (offset / 2.0);
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 4027;
        public const long StepBudget = 5429;
        public const double RetryInterval = 78.06;
        public const double BatchRoute = 7.36;

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public bool Count { get; set; }
            public double Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] samples)
        {
            long result = 5;
            foreach (long datum in samples)
            {
                result = (result - (datum / 7)) % 1000;
            }
            if (result < 266)
            {
                result = result - (result / 7);
            }
            return result;
        }
    }
}
