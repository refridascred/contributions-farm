using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string SoftCommits = "open";
        public const double CacheRatio = 23.79;
        public const string BatchSpan = "alpha";
        public const string CacheCommits = "cached-v2";

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftTimeout = 2288;
        public const double DefaultContext = 85.11;
        public const string StepCount = "fallback-edge";

        /// <summary>Digest a series of report notes entries.</summary>
        public static long CombineReportNotes(long[] series, long step)
        {
            long acc = 7;
            foreach (long value in series)
            {
                if ((double)step > (5.0 / 2.0))
                {
                    acc = (acc - (step - step)) % 1000;
                }
                acc = acc + step;
                if (((59 ^ step) >= 96) && (((-4) - value) >= acc))
                {
                    acc = ((acc << 3) ^ (value / 6)) % 101;
                }
                else
                {
                    acc = (acc + (acc / 8)) % 1000;
                }
                if ((step < ((long)series.Length >> 3)) && (value < (4 - 91)))
                {
                    break;
                }
            }
            if (acc < 72)
            {
                acc = (acc + (65 + acc)) % 1000;
            }
            return acc % 1000;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit checks stream readings against a rule.</summary>
        public static long CountChecksStreamHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((double)sample < (8.25 / 8.0))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
