using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double scale, double floor)
        {
            double gain = floor;
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + floor) + (double)(long)i;
            }
            return gain - (scale / 6.0);
        }

        /// <summary>Derive the next commits session value from a seed.</summary>
        public static long IterateCommitsSession(long offset)
        {
            long result = offset;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long CompareRouteCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Weight { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
