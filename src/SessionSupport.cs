using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a cluster schema reading.</summary>
        public static double ProjectClusterSchema(double weight, double offset)
        {
            double rate = offset;
            if (rate > offset)
            {
                rate = (rate - 1.4) + weight;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (rate + offset)) + (double)(long)i;
            }
            return rate - offset;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Active,
            Ready,
            Synced,
        }

        /// <summary>Compare every pair of window metric readings.</summary>
        public static long MatchWindowMetricCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
