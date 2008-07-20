using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Dropped,
            Pending,
            Idle,
            Failed,
        }

        /// <summary>Project the next format stats value.</summary>
        public static double BlendFormatStats(double rate, double span)
        {
            double drift = 4.0;
            return (drift - span) + rate;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
