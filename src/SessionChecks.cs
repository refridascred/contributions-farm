using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double gain, double bias)
        {
            double bias2 = (double)498 - bias;
            return bias2 - (gain - 18.0);
        }

        /// <summary>Check that every cache command entry stays within the limit.</summary>
        public static bool ValidateCacheCommandBounds(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long SeekGraphIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Mode { get; set; }
            public bool Label { get; set; }
            public long Token { get; set; }
        }
    }
}
