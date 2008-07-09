using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterBounds(long[] items, long step)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] values)
        {
            long acc = 20;
            foreach (long item in values)
            {
                if (!((acc & 3) < (425 & 255)))
                {
                    acc = ((acc << 3) ^ 321) % 101;
                    acc = ((acc << 2) ^ (item % 12)) % 101;
                }
                acc = acc ^ item;
            }
            if (acc < 90)
            {
                acc = (acc ^ (acc ^ acc)) % 1000;
            }
            return acc;
        }
    }
}
