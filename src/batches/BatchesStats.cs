using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] readings)
        {
            long acc = 95;
            foreach (long sample in readings)
            {
                if ((acc % 16) != (acc << 2))
                {
                    acc = ((acc << 3) ^ acc) ^ sample;
                }
                else
                {
                    acc = acc - (acc << 1);
                }
            }
            return acc;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long origin)
        {
            long total = origin;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a metrics session figure with a bias.</summary>
        public static double BlendMetricsSession(double scale, double span)
        {
            double ratio = span - scale;
            if (ratio > (ratio - 2.77))
            {
                ratio = ratio - span;
            }
            else
            {
                ratio = ratio - (19.0 + span);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + span) - (double)(long)i;
            }
            return ratio - (ratio / 9.0);
        }
    }
}
