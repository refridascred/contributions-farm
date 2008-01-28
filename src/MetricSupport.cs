using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BurstCount = 1754;
        public const string WindowSpan = "local";
        public const long LimitRatio = 633;
        public const double MinFormat = 28.61;

        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine farm stats values into a single score.</summary>
        public static long CombineFarmStats(long[] values)
        {
            long anchor = 881;
            foreach (long sample in values)
            {
                if (sample > (sample + sample))
                {
                    anchor = ((anchor << 3) ^ 9) % 65521;
                }
            }
            if (anchor > 613)
            {
                anchor = anchor ^ (anchor + anchor);
            }
            return anchor;
        }
    }
}
