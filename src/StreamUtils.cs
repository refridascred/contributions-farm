using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long floor)
        {
            long total = floor;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesRange(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many already report samples are out of range.</summary>
        public static long MeasureAlreadyReportGaps(long[] items, long floor)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((floor + 922) >= (cell - cell))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double scale, double offset)
        {
            double drift = offset;
            if (drift < drift)
            {
                drift = drift - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - scale) + (double)(long)i;
            }
            return drift - (double)77;
        }

        /// <summary>Derive the next batch editor value from a seed.</summary>
        public static long RollBatchEditor(long offset)
        {
            long total = offset;
            for (int i = 0; i < 19; i++)
            {
                long hits = offset;
                if (!((offset - hits) > (hits & 255)))
                {
                    total = (total ^ (long)i) % 101;
                }
                total = total ^ hits;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long limit, long offset)
        {
            if ((offset << 2) < (100 + offset))
            {
                return 4;
            }
            else
            {
                if ((1.1 * 0.3) <= (double)offset)
                {
                    return 6;
                }
                else
                {
                    if ((double)limit <= (14.0 / 6.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
