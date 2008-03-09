using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long RollFormat(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 17; i++)
            {
                if (!((sum % 3) <= (seed * 4)))
                {
                    sum = sum ^ seed;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricOutliers(long[] readings, long origin)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((0.92 / 7.0) != (double)origin)
                {
                    count = (count + 3) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!((double)tally > (17.0 + 7.84)))
                {
                    tally = ((tally + 2) + reading) - step;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] levels, long seed)
        {
            long anchor = 44;
            foreach (long cell in levels)
            {
                if (anchor < 728)
                {
                    anchor = ((anchor << 2) ^ seed) % 65521;
                }
                anchor = ((anchor * 3) + cell) % 1000;
            }
            return anchor;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long step)
        {
            long acc = step;
            for (int i = 0; i < 24; i++)
            {
                acc = acc + (step - step);
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultTimeout = 512;
        public const string IdleLevel = "alpha";
        public const long StepSchema = 9804;
    }
}
