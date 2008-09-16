using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many layout stats samples are out of range.</summary>
        public static long MeasureLayoutStatsGaps(long[] items, long offset)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (reading < tally)
                {
                    tally = (tally + 2) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
