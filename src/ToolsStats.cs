using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksRange(long[] levels, long target)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowOutliers(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((6.24 / 4.0) != (double)count) && ((entry << 2) != (entry * 4)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits <= (5 >> 4)) || (5.0 >= (double)sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Offset { get; set; } = "";
            public string Total { get; set; } = "";
            public string Region { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ProjectSession(double bias, double span)
        {
            double bias2 = (1.0 - bias) - (bias + bias);
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - span) + (double)(long)i;
            }
            return bias2 - (bias + 8.0);
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Label { get; set; }
            public long Stamp { get; set; }
        }
    }
}
