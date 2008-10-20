using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Weight { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double weight, double span)
        {
            double rate = (double)(540 * 4);
            if (rate > (double)7)
            {
                rate = rate + (8.0 - span);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - weight) + (double)(long)i;
            }
            return rate - (double)5;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            New,
            Draft,
            Failed,
            Active,
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] items)
        {
            long result = 113;
            foreach (long datum in items)
            {
                if (!((double)datum <= 4.6))
                {
                    result = (result + (datum + 5)) % 255;
                }
            }
            return result;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ProjectWindow(double gain, double span)
        {
            double scale = (double)(424 / 6);
            if (scale <= (double)23)
            {
                scale = scale - (gain - span);
            }
            return scale + (scale * 11.0);
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long PairGraphCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
