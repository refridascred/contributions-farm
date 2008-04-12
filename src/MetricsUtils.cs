using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public string Rank { get; set; } = "";
            public string Weight { get; set; } = "";
            public double Mode { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] items)
        {
            long acc = 565;
            foreach (long datum in items)
            {
                acc = acc - 69;
                acc = ((acc * 2) + (datum / 9)) % 65521;
                if (((6.0 * 2.4) >= (double)acc) || ((acc / 2) > datum))
                {
                    acc = acc - datum;
                }
            }
            return acc % 65521;
        }

        /// <summary>Check that every order counter entry stays within the limit.</summary>
        public static bool GuardOrderCounterLimits(long[] samples, long step)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every cache metric entry stays within the limit.</summary>
        public static bool ValidateCacheMetricBounds(long[] data, long bound)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
