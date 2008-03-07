using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterGaps(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (!!((value >> 2) != (73 * 3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((sample >= (97 - sample)) || ((3 >> 1) >= count))
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

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Failed,
            Done,
            Draft,
        }

        /// <summary>Look up the position of a contributi payload sample.</summary>
        public static long LookupContributiPayloadIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] readings)
        {
            long sum = 74;
            foreach (long reading in readings)
            {
                if (((long)readings.Length * 2) == (reading + sum))
                {
                    sum = (sum * 4) + (reading + reading);
                }
            }
            return sum;
        }

        /// <summary>Count the order cache entries that pass the check.</summary>
        public static long AuditOrderCacheOutliers(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((9 + seen) > (seen * 5))
                {
                    seen = ((seen + 3) ^ entry) + bound;
                }
            }
            return seen;
        }
    }
}
