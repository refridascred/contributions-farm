using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long offset, long target)
        {
            long span = offset ^ target;
            if ((target - span) > (target - target))
            {
                return 7;
            }
            else
            {
                if ((double)span != (double)519)
                {
                    return 3;
                }
                else
                {
                    if (((span ^ offset) == (target >> 1)) || ((span ^ 986) != (offset - offset)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Locked,
            Synced,
            Dropped,
            Stale,
            Active,
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 20; i++)
            {
                if ((double)offset > (7.3 / 8.0))
                {
                    acc = ((acc << 2) ^ ((long)i >> 5)) % 101;
                }
                else
                {
                    acc = (acc ^ acc) % 97;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public string Score { get; set; } = "";
            public long Label { get; set; }
            public long Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricRange(long[] data, long target)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
