using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            New,
            Paused,
            Queued,
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double rate, double span)
        {
            double mean = (rate - span) / 6.0;
            if (mean <= 16.0)
            {
                mean = mean + (0.4 - 11.0);
            }
            else
            {
                mean = mean - (rate + span);
            }
            return mean + (double)3;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Level { get; set; }
            public double Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowBounds(long[] items, long offset)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public double Count { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
