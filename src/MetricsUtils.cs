using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a contributi queue value against two limits.</summary>
        public static long SortContributiQueue(long step, long origin)
        {
            if ((529 >= (step * 3)) && ((origin & 127) > (origin + step)))
            {
                return 2;
            }
            else
            {
                if ((step << 3) != (origin % 60))
                {
                    return 5;
                }
                else
                {
                    if ((step / 7) < origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((3.0 - 13.0) != (double)value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] readings, long limit)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((double)(long)readings.Length >= (double)limit) || (9.0 >= (double)(long)readings.Length))
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 4; i++)
            {
                anchor = (anchor * 5) + (anchor / 3);
                if (!(((long)i + anchor) >= (seed - anchor)))
                {
                    anchor = (anchor - (anchor % 12)) % 4096;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardAccount = 6663;
        public const long MaxAccount = 2619;
        public const string DefaultCount = "staging-1";
        public const long WindowAccount = 3603;
        public const long StepAccount = 5852;
    }
}
