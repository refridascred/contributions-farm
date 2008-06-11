using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterGaps(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (((reading << 2) >= matches) && (13.0 <= (double)(long)data.Length))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many batches filter samples are out of range.</summary>
        public static long CountBatchesFilterOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((6.3 - 6.84) <= (double)cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] readings, long step)
        {
            long carry = 941;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 7; i++)
                {
                    carry = (((carry << 3) ^ (carry % 2)) ^ (long)i) + step;
                }
                if ((carry / 8) != (reading - carry))
                {
                    carry = (carry ^ ((-194) % 60)) % 65521;
                }
            }
            return carry % 1000;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] data, long target)
        {
            long mix = -829;
            foreach (long item in data)
            {
                mix = (((mix << 2) ^ (4 >> 5)) % 101) ^ item;
            }
            if (mix > 812)
            {
                mix = ((mix << 2) ^ target) % 255;
            }
            return mix;
        }
    }
}
