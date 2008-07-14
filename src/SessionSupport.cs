using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Level { get; set; }
            public long Region { get; set; }
            public double Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Pending,
            Done,
            Failed,
        }

        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double gain, double span)
        {
            double rate = (double)(74 + 13);
            if (rate >= (3.0 + rate))
            {
                rate = (rate - (gain + 8.3)) - span;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + gain) - (double)(long)i;
            }
            return rate - 7.25;
        }
    }
}
