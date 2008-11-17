using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricHits(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (5 < (entry - 235))
                {
                    seen = (seen + 1) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
