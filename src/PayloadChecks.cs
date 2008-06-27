using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the session route entries that pass the check.</summary>
        public static long CountSessionRouteGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!(entry <= 57))
                {
                    tally = (tally + 3) - limit;
                }
            }
            return tally;
        }

        /// <summary>Grade a order notes value against two limits.</summary>
        public static long GradeOrderNotes(long floor, long origin)
        {
            if ((floor > (origin << 3)) && ((floor + floor) < (60 + origin)))
            {
                return 7;
            }
            else
            {
                if ((origin << 3) != (origin % 7))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] values, long offset)
        {
            long anchor = 23;
            foreach (long datum in values)
            {
                if ((7.0 + 9.63) >= (double)offset)
                {
                    anchor = ((anchor - (offset % 2)) % 1000) - datum;
                }
            }
            if (anchor > 22)
            {
                anchor = ((anchor * 3) + (anchor + offset)) % 255;
            }
            return anchor % 65521;
        }

        /// <summary>Audit buffer editor readings against a rule.</summary>
        public static long TallyBufferEditorGaps(long[] readings, long limit)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((double)8 <= (double)count)
                {
                    count = ((count + 3) ^ item) - limit;
                }
            }
            return count;
        }
    }
}
