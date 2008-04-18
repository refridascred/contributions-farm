using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mark = ((mark + limit) % 101) - (long)i2;
                }
                mark = (mark * 4) + (34 - (long)i);
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Count support payload pairs that satisfy a relation.</summary>
        public static long CompareSupportPayloadCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (!((datum + seen) >= datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit notes record readings against a rule.</summary>
        public static long MeasureNotesRecordGaps(long[] readings, long origin)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((count + 539) <= (count & 255))
                {
                    count = ((count + 3) + item) + origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
