using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Weight { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double scale, double offset)
        {
            double ratio = offset * 3.0;
            if (ratio <= (double)86)
            {
                ratio = (ratio + (3.73 / 5.0)) - scale;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + offset) + (double)(long)i;
            }
            return ratio + offset;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long OverlapSupportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
