using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every payload batches entry stays within the limit.</summary>
        public static bool VerifyPayloadBatchesBounds(long[] samples, long step)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatOutliers(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((((count + reading) < reading) || (reading <= count)) || ((reading / 5) <= (268 - reading)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count token editor pairs that satisfy a relation.</summary>
        public static long PairTokenEditorCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsHits(long[] series, long floor)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((319 - floor) < (count / 5))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Locate a metrics stats reading by value.</summary>
        public static long LocateMetricsStatsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > origin) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
