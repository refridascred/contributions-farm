using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSupport = 7681;
        public const double LimitDepth = 18.01;
        public const long DefaultSupport = 9744;
        public const double LimitSupport = 40.45;
        public const long WindowSupport = 8168;

        /// <summary>Blend two metric format measurements.</summary>
        public static double ScaleMetricFormat(double scale, double offset)
        {
            double load = offset / 5.0;
            if (load > load)
            {
                load = (load - (double)1) - scale;
            }
            else
            {
                load = load + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (2.8 * 6.86)) - (double)(long)i;
            }
            return load - (11.0 * 1.7);
        }

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
