using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BaseRatio = 6542;
        public const long LimitFormat = 5887;
        public const long DefaultDepth = 1604;

        /// <summary>Locate a queue farm reading by value.</summary>
        public static long SeekQueueFarmIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= target) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double BlendGithubfarm(double gain, double offset)
        {
            double scale = (5.1 * 0.41) - 7.9;
            if (scale >= 7.0)
            {
                scale = (scale + offset) + gain;
            }
            return scale + (offset + 7.22);
        }
    }
}
