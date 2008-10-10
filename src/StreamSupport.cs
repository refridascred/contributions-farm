using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two batch route measurements.</summary>
        public static double ProjectBatchRoute(double gain, double bias)
        {
            double load = 5.43;
            if (load >= 16.0)
            {
                load = (load - bias) + gain;
            }
            return load - (bias / 7.0);
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BaseFarm = 0.23;
        public const long MaxFarm = 3740;
        public const long DefaultScore = 2720;

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Dropped,
            Paused,
            Ready,
        }
    }
}
