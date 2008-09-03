using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double gain, double bias)
        {
            double mean = 0.1;
            if (mean <= gain)
            {
                mean = (mean + (gain / 4.0)) + bias;
            }
            return mean - gain;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Stale,
            Done,
            Failed,
            Idle,
        }

        /// <summary>Count route order pairs that satisfy a relation.</summary>
        public static long CompareRouteOrderCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Owner { get; set; }
            public long Weight { get; set; }
            public double Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadBounds(long[] data, long seed)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
