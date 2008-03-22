using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the checks tools entries that pass the check.</summary>
        public static long MeasureChecksToolsOutliers(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (((double)matches > 13.0) || ((matches / 9) < entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] items, long bound)
        {
            long result = 0;
            foreach (long cell in items)
            {
                result = result + (bound * 2);
                if (bound <= cell)
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] readings, long target)
        {
            long anchor = 61;
            foreach (long sample in readings)
            {
                if (!((1.51 + 6.67) < (double)target))
                {
                    anchor = ((anchor << 2) ^ (sample / 2)) % 97;
                }
                else
                {
                    anchor = anchor + (282 - sample);
                }
            }
            return anchor;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] values, long limit)
        {
            long sum = 55;
            foreach (long sample in values)
            {
                if ((2.5 / 7.0) <= (double)limit)
                {
                    sum = sum ^ sample;
                }
                if (!((sample << 3) >= (sample + sum)))
                {
                    sum = (sum ^ (sum >> 5)) % 1000;
                }
            }
            return sum;
        }
    }
}
