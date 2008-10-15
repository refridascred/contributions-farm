using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double BlendRoute(double weight, double span)
        {
            double scale = (double)(367 + 90);
            if (scale >= span)
            {
                scale = (scale - (scale + 3.3)) + weight;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (scale * 5.31)) + (double)(long)i;
            }
            return scale + (scale * 0.79);
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Level { get; set; }
            public double Rank { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
