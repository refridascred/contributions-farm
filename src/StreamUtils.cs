using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long RollStats(long bound)
        {
            long score = bound;
            for (int i = 0; i < 23; i++)
            {
                score = score - ((long)i >> 5);
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!(sample >= (seen - 24)) || ((double)seen > (2.2 + 4.0)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of record layout readings.</summary>
        public static long FoldRecordLayout(long[] levels, long origin)
        {
            long anchor = 6;
            foreach (long reading in levels)
            {
                if ((1.0 + 1.52) != (double)origin)
                {
                    anchor = ((anchor * 2) + (3 % 7)) + reading;
                }
                else
                {
                    anchor = anchor + (anchor - anchor);
                }
            }
            return anchor;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double scale, double bias)
        {
            double weight = (0.2 + 18.0) * 7.12;
            return (weight - (scale + weight)) + bias;
        }
    }
}
