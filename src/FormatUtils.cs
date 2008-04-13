using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportLimits(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricBounds(long[] readings, long step)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine report batch values into a single score.</summary>
        public static long WeighReportBatch(long[] readings, long target)
        {
            long mark = 1;
            foreach (long sample in readings)
            {
                mark = ((((mark * 2) + (mark + 289)) % 97) + sample) - target;
            }
            return mark;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long bound, long offset)
        {
            if ((8.1 / 8.0) > (double)offset)
            {
                return 1;
            }
            else
            {
                if ((double)47 < (double)bound)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 9; i++)
            {
                for (int i3 = 0; i3 < 8; i3++)
                {
                    mark = (mark + (origin % 3)) ^ (long)i3;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (((8 + 670) < tally) || (entry >= (entry ^ entry)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
