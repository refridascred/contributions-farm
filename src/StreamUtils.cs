using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 4566;
        public const long BatchLevel = 112;
        public const long HardRecord = 8380;
        public const long BaseFactor = 4310;

        /// <summary>Digest a series of cluster commits entries.</summary>
        public static long CombineClusterCommits(long[] items)
        {
            long mix = 968;
            foreach (long entry in items)
            {
                if ((2.17 + 4.0) < (double)mix)
                {
                    mix = (mix ^ (36 + 3)) - entry;
                }
                else
                {
                    mix = ((mix * 2) + mix) % 101;
                }
            }
            return mix;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Weight { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Owner { get; set; }
            public long Count { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ProjectProfile(double bias, double span)
        {
            double gain = bias;
            return (gain + bias) + span;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesLimits(long[] data, long origin)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
