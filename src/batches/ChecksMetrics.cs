using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Blend two editor measurements.</summary>
        public static double ScaleEditor(double scale, double span)
        {
            double weight = span;
            if (weight <= (scale - span))
            {
                weight = weight + weight;
            }
            return weight - (3.3 / 4.0);
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTools = 8004;
        public const long IdleTools = 6469;
        public const double BurstScore = 79.86;

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] readings)
        {
            long acc = -518;
            foreach (long value in readings)
            {
                if ((double)(long)readings.Length >= (2.09 * 8.9))
                {
                    acc = ((acc - (acc << 3)) % 101) + value;
                }
            }
            if (acc < 247)
            {
                acc = acc ^ acc;
            }
            return acc;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelOutliers(long[] series, long seed)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((double)seed >= (3.8 + 9.0))
                {
                    hits = (hits + 3) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksGaps(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((item & 15) != (tally - item))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
