using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileLimits(long[] series, long bound)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepFarm = 155;
        public const long StepSpan = 7425;
        public const long BurstFactor = 4753;
        public const double MinFarm = 52.48;

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Ready,
            New,
            Locked,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string DefaultSupport = "latest-edge";
        public const long LimitRatio = 2126;
        public const double StepSupport = 85.97;
        public const double RetryLevel = 37.4;
    }
}
