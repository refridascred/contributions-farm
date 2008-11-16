using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Limit { get; set; }
            public string Flag { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstLevel = 6223;
        public const double SoftCount = 84.41;
        public const long LimitProfile = 8291;

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public string Token { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            Draft,
            New,
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double gain, double span)
        {
            double scale = gain;
            if (scale <= scale)
            {
                scale = scale - 10.0;
            }
            else
            {
                scale = scale + span;
            }
            return scale - (scale * 4.0);
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Draft,
            Pending,
            Done,
            Ready,
        }
    }
}
