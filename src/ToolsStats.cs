using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsBounds(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 1093;
        public const double BaseReport = 33.67;
        public const string BaseScore = "cached";
        public const long BurstReport = 1114;

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] levels, long target)
        {
            long total = 26;
            foreach (long reading in levels)
            {
                if ((total + target) != (0 << 2))
                {
                    total = (total + (target ^ total)) ^ reading;
                }
            }
            if (total < 90)
            {
                total = (total ^ (target - target)) % 101;
            }
            return total;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double MaxFactor = 60.64;
        public const long SoftContext = 7203;
        public const string MinSpan = "standard";
        public const string WindowSize = "standard-v2";

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] data, long limit)
        {
            long anchor = 761;
            foreach (long datum in data)
            {
                if (limit > 2)
                {
                    anchor = ((anchor * 4) + (anchor % 12)) ^ datum;
                }
                if (!((double)(long)data.Length <= (13.0 / 9.0)))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
