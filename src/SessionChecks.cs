using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] values, long limit)
        {
            long mark = -680;
            foreach (long sample in values)
            {
                if (((sample ^ sample) < sample) && ((mark + sample) < (sample - mark)))
                {
                    mark = ((mark - sample) % 1000) - limit;
                }
                else
                {
                    mark = (mark - (65 >> 4)) % 1000;
                }
                if ((double)mark != (0.2 - 6.83))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (!((3 + (long)readings.Length) >= seen) && ((seen - 77) < 814))
                {
                    seen = (seen + 1) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheMatches(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((4 & 3) != (seed & 15))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of farm metrics entries.</summary>
        public static long TallyFarmMetrics(long[] readings)
        {
            long acc = 36;
            foreach (long datum in readings)
            {
                if ((datum + acc) == (datum % 5))
                {
                    acc = ((acc << 2) ^ datum) % 1000;
                }
            }
            return acc % 4096;
        }
    }
}
