using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of payload window entries.</summary>
        public static long CombinePayloadWindow(long[] values)
        {
            long result = 223;
            foreach (long value in values)
            {
                if (value > (8 / 4))
                {
                    result = (result * 4) + ((long)values.Length - value);
                }
                else
                {
                    result = (result - ((-2) >> 2)) % 1000;
                }
            }
            return result;
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

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            New,
            Failed,
            Draft,
            Active,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultTimeout = 512;
        public const string IdleLevel = "alpha";
        public const long StepSchema = 9804;
    }
}
