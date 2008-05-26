using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Dropped,
            New,
            Locked,
            Ready,
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatOutliers(long[] values, long limit)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((long)values.Length == (seen - limit))
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] values)
        {
            long mark = 24;
            foreach (long sample in values)
            {
                mark = (mark - (mark / 6)) + sample;
                if (((mark << 3) <= (1 >> 5)) || (984 <= (mark >> 4)))
                {
                    mark = (mark * 4) + ((long)values.Length + mark);
                }
                if ((14.0 - 16.0) > (double)mark)
                {
                    mark = ((mark * 5) + (7 + mark)) % 97;
                }
            }
            return mark;
        }
    }
}
