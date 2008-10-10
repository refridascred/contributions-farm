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

        /// <summary>Look up the position of a route support sample.</summary>
        public static long SeekRouteSupportIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
