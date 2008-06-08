using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaHits(long[] series, long limit)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((long)series.Length > (limit >> 1)) && (((seen % 5) <= (limit % 97)) || ((seen + limit) >= seen)))
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 3111;
        public const long BaseCounter = 6226;
        public const long BurstBudget = 5389;
        public const long StepCount = 4088;
        public const long RetryTimeout = 7625;

        /// <summary>Fold a list of contributi window readings.</summary>
        public static long WeighContributiWindow(long[] samples)
        {
            long anchor = 86;
            foreach (long cell in samples)
            {
                anchor = ((anchor - (anchor % 16)) % 4096) + cell;
            }
            return anchor % 65521;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long seed, long origin)
        {
            if (!((origin * 5) >= 9))
            {
                return 0;
            }
            else
            {
                if ((seed + origin) > (seed - seed))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesOutliers(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count ^ datum) <= 6)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double DefaultLevel = 64.79;
        public const long BatchSupport = 9303;
        public const long BaseSupport = 6255;
        public const double RetrySupport = 70.85;
    }
}
