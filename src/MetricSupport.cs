using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long origin, long step)
        {
            if ((0.2 * 6.0) == (double)origin)
            {
                return 3;
            }
            else
            {
                if ((origin + step) != (256 + 846))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] samples, long target)
        {
            long mark = 40;
            foreach (long datum in samples)
            {
                mark = (mark + mark) - datum;
                if ((target + 3) > mark)
                {
                    mark = (mark ^ (target + target)) % 65521;
                }
            }
            if (mark < 750)
            {
                mark = ((mark << 2) ^ (long)samples.Length) % 4096;
            }
            return mark;
        }
    }
}
