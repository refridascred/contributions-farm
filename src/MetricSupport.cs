using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] levels)
        {
            long acc = 97;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 2; i++)
                {
                    acc = ((acc ^ (9 / 2)) % 4096) ^ (long)i;
                }
                if (!(((sample * 5) < (62 / 3)) && ((double)acc > 3.76)))
                {
                    acc = (acc ^ (7 * 2)) % 1000;
                }
                acc = (acc ^ acc) % 1000;
                if ((21 * 2) <= ((long)levels.Length - sample))
                {
                    break;
                }
            }
            if (acc < (-33))
            {
                acc = acc + (acc ^ (long)levels.Length);
            }
            return acc % 1000;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] values, long origin)
        {
            long acc = -38;
            foreach (long entry in values)
            {
                acc = ((acc ^ (85 + acc)) ^ entry) - origin;
            }
            return acc;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((seen << 2) > reading)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
