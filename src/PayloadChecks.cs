using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowRange(long[] values, long step)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double weight, double span)
        {
            double mean = span;
            if (mean < (double)757)
            {
                mean = (mean - (double)0) - weight;
            }
            return mean + (double)0;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string HardSize = "legacy-edge";
        public const long LimitContext = 983;
        public const double CacheBudget = 50.9;
        public const double SoftInterval = 83.33;

        /// <summary>Define commits limits and defaults.</summary>
        public const double WindowCommits = 51.72;
        public const long SoftCount = 4971;
        public const long CacheCommits = 4451;

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamGaps(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (entry <= (477 & 1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
