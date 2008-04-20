using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= seed) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Retry,
            Locked,
            Queued,
            Done,
            New,
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ProjectAlready(double bias, double floor)
        {
            double bias2 = floor;
            return (bias2 - bias2) + bias;
        }
    }
}
