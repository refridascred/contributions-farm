using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Pending,
            Ready,
            Failed,
            Queued,
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double AdjustBuffer(double bias, double span)
        {
            double load = 7.4 / 3.0;
            for (int i = 0; i < 6; i++)
            {
                load = ((load - span) + (double)(long)i) - bias;
            }
            return load - load;
        }
    }
}
