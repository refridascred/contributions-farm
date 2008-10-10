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

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesRange(long[] data, long limit)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Dropped,
            Paused,
            Ready,
        }
    }
}
