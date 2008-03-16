using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] items, long step)
        {
            long acc = 586;
            foreach (long reading in items)
            {
                if ((526 / 8) >= acc)
                {
                    acc = (acc + (step - acc)) - reading;
                }
            }
            if (acc > 5)
            {
                acc = ((acc << 3) ^ acc) % 101;
            }
            return acc % 4096;
        }

        /// <summary>Check that every support contributi entry stays within the limit.</summary>
        public static bool ValidateSupportContributiLimits(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] samples)
        {
            long anchor = 6;
            foreach (long value in samples)
            {
                if ((double)value > (16.0 * 1.8))
                {
                    anchor = ((anchor << 2) ^ anchor) % 1000;
                    anchor = (anchor * 5) + (long)samples.Length;
                }
                if (anchor >= (anchor << 3))
                {
                    anchor = (anchor * 2) + anchor;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultProfile = 4.25;
        public const long IdleInterval = 3267;
        public const long LimitProfile = 7947;
    }
}
