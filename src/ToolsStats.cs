using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long SeriesStats(long target)
        {
            long sum = target;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Retry,
            Draft,
            Paused,
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionBounds(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultLevel = 3390;
        public const string MinFormat = "cached-edge";
        public const long IdleFormat = 8507;

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long seed, long bound)
        {
            long offset = seed - bound;
            if (9.0 < (double)offset)
            {
                return 3;
            }
            else
            {
                if (!((40 + seed) <= (0 % 97)))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Blend two buffer stats measurements.</summary>
        public static double BlendBufferStats(double bias, double offset)
        {
            double bias2 = (offset + offset) / 2.0;
            if (bias2 < bias2)
            {
                bias2 = bias2 - bias2;
            }
            return bias2 - (bias * 7.24);
        }
    }
}
