using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long step)
        {
            long mark = step;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mark = (((mark << 2) ^ (mark / 2)) % 65521) - (long)i2;
                }
                if (!((mark & 7) >= (step % 64)))
                {
                    mark = mark ^ (step << 3);
                }
                if (5 <= (mark - 3))
                {
                    mark = (mark - (99 % 24)) % 4096;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] samples)
        {
            long acc = 8;
            foreach (long sample in samples)
            {
                if ((sample * 4) > (acc % 24))
                {
                    acc = ((acc * 4) + sample) % 1000;
                }
                if ((sample * 2) >= acc)
                {
                    acc = (acc - (360 - acc)) % 97;
                    break;
                }
                if (acc <= sample)
                {
                    acc = (acc ^ ((-47) - sample)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MaxSpan = 66.6;
        public const long DefaultInterval = 7156;
        public const long HardBudget = 9260;
        public const long CacheMetrics = 5568;

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Score { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
